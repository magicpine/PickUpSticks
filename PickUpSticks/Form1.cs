using System;
using System.Windows.Forms;

namespace PickUpSticks
{
    /// <summary>
    /// Tells Us Which Players Are Avaiable
    /// </summary>
    enum Players
    {
        One = 0,
        Two = 1
    }

    /// <summary>
    /// The Game
    /// </summary>
    public partial class pickUpSticksFrm : Form
    {
        #region Variables

        private decimal _NumberOfSticks;
        private Players _CurrentPlayer;
        private AI _PlayerOneAI;
        private AI _PlayerTwoAI;

        #endregion Varaiables

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public pickUpSticksFrm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Events

        /// <summary>
        /// Handles the Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pickUpSticksFrm_Load(object sender, EventArgs e)
        {
            GameDefaults();
        }

        /// <summary>
        /// Starts the Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            //Clear Out Old Game
            logLst.Items.Clear();
            //Enable the Three buttons
            playerOneThreeStickBtn.Enabled = true;
            playerTwoThreeStickBtn.Enabled = true;
            //Set the Label And Number Of Sticks
            sticksLbl.Text = sticksNud.Value.ToString();
            _NumberOfSticks = sticksNud.Value;
            //Game Starting
            optionsPnl.Enabled = false;
            gamePnl.Enabled = true;
            StartGame();
            //Set Up Player One AI
            if (_PlayerOneAI == null)
                _PlayerOneAI = new AI(sticksNud.Value);
            else
                _PlayerOneAI.NewGame(sticksNud.Value);
            //Set up Player Two AI
            if (_PlayerTwoAI == null)
                _PlayerTwoAI = new AI(sticksNud.Value);
            else
                _PlayerTwoAI.NewGame(sticksNud.Value);
            //Make the AI go first if its their turn
            if (_CurrentPlayer == Players.One && playerOneAiRb.Checked)
            {
                PickUpSticks(_PlayerOneAI.PickUpSticks(sticksNud.Value));
            }
            else if (_CurrentPlayer == Players.Two && playerTwoAiRb.Checked)
            {
                PickUpSticks(_PlayerTwoAI.PickUpSticks(sticksNud.Value));
            }
        }

        /// <summary>
        /// Handles the Buttons that Pick Up Sticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PickUpSticksbtn_Click(object sender, EventArgs e)
        {
            if (sender == playerOneOneStickBtn || sender == playerTwoOneStickBtn)
                PickUpSticks(1);
            else if (sender == playerOneTwoStickBtn || sender == playerTwoTwoStickBtn)
                PickUpSticks(2);
            else
                PickUpSticks(3);
        }

        #endregion Events

        #region Methods

        /// <summary>
        /// Sets the Game Defaults
        /// </summary>
        private void GameDefaults()
        {
            //Default Game, Start of the game
            optionsPnl.Enabled = true;
            gamePnl.Enabled = false;
            playerOneHumanRb.Checked = true;
            playerTwoAiRb.Checked = true;
            playerOneThreeStickBtn.Enabled = true;
            playerTwoThreeStickBtn.Enabled = true;
            sticksNud.Value = 20;
            logLst.Items.Clear();
        }
        
        /// <summary>
        /// Starts the Game
        /// </summary>
        private void StartGame()
        {
            //Figure Out Turn Order
            TurnOrder();
            //Disable the Correct Panel
            playerOnePnl.Enabled = _CurrentPlayer == Players.One ? true : false;
            playerTwoPnl.Enabled = _CurrentPlayer == Players.Two ? true : false;
        }

        /// <summary>
        /// Sets the Turn Order at the start
        /// </summary>
        private void TurnOrder()
        {
            Random rng = new Random();
            _CurrentPlayer = (Players)rng.Next(2);
        }

        /// <summary>
        /// Picks up the Sticks from the Pile
        /// </summary>
        /// <param name="numberOfSticksBeingPickedUp"></param>
        private void PickUpSticks(decimal numberOfSticksBeingPickedUp)
        {
            //Update Stats
            _NumberOfSticks -= numberOfSticksBeingPickedUp;
            sticksLbl.Text = _NumberOfSticks.ToString();
            logLst.Items.Add("Player " + _CurrentPlayer + " Picked Up " + numberOfSticksBeingPickedUp.ToString() + " sticks(s).  Sticks Left: " + _NumberOfSticks.ToString());
            logLst.SelectedIndex = logLst.Items.Count - 1;
            //Checks to see if we lose Switch Players
            if (_NumberOfSticks == 0)
            {
                //The Current Player Loses
                GameOver();
            }
            else if (_NumberOfSticks == 1)
            {
                //The Next Players Turn Is the One Who Loses
                SwitchPlayers(true);
                GameOver();
            }
            else
                SwitchPlayers(false);

            //See If We Need to Disable the Three Sticks Button
            if (_NumberOfSticks == 2)
            {
                playerOneThreeStickBtn.Enabled = false;
                playerTwoThreeStickBtn.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Game Over Stuff
        /// </summary>
        private void GameOver()
        {
            logLst.Items.Add("Player " + _CurrentPlayer + " Loses");
            logLst.SelectedIndex = logLst.Items.Count - 1;
            gamePnl.Enabled = false;
            optionsPnl.Enabled = true;
            //If AI was playing Update The Learning
            if (playerOneAiRb.Checked)
            {
                if (_CurrentPlayer == Players.One)
                    _PlayerOneAI.SeedInLearning(false);
                else
                    _PlayerOneAI.SeedInLearning(true);
            }
            if (playerTwoAiRb.Checked)
            {
                if (_CurrentPlayer == Players.Two)
                    _PlayerTwoAI.SeedInLearning(false);
                else
                    _PlayerTwoAI.SeedInLearning(true);
            }
        }

        /// <summary>
        /// Switches the Players 
        /// </summary>
        /// <param name="isGameOver"></param>
        private void SwitchPlayers(bool isGameOver)
        {
            //Swap the Current Player
            if (_CurrentPlayer == Players.One)
                _CurrentPlayer = Players.Two;
            else
                _CurrentPlayer = Players.One;
            //If the Game Isn't Over 
            if (!isGameOver)
            {
                //Swap Game Panels For Players
                playerOnePnl.Enabled = !playerOnePnl.Enabled;
                playerTwoPnl.Enabled = !playerTwoPnl.Enabled;

                //Check for AI 
                if ((playerOneAiRb.Checked && _CurrentPlayer == Players.One) || (playerTwoAiRb.Checked && _CurrentPlayer == Players.Two))
                {
                    int pickedUpSticks = 0;
                    if (_CurrentPlayer == Players.One)
                        pickedUpSticks = _PlayerOneAI.PickUpSticks(_NumberOfSticks);
                    else
                        pickedUpSticks = _PlayerTwoAI.PickUpSticks(_NumberOfSticks);
                    PickUpSticks(pickedUpSticks);
                }
            }
        }

        #endregion Methods
    }
}