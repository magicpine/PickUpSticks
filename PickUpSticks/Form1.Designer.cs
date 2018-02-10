namespace PickUpSticks
{
    partial class pickUpSticksFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gamePnl = new System.Windows.Forms.Panel();
            this.sticksLbl = new System.Windows.Forms.Label();
            this.logLst = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playerTwoPnl = new System.Windows.Forms.Panel();
            this.playerTwoThreeStickBtn = new System.Windows.Forms.Button();
            this.playerTwoTwoStickBtn = new System.Windows.Forms.Button();
            this.playerTwoOneStickBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.playerOnePnl = new System.Windows.Forms.Panel();
            this.playerOneThreeStickBtn = new System.Windows.Forms.Button();
            this.playerOneTwoStickBtn = new System.Windows.Forms.Button();
            this.playerOneOneStickBtn = new System.Windows.Forms.Button();
            this.optionsPnl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.playerTwoAiRb = new System.Windows.Forms.RadioButton();
            this.playerTwoHumanRb = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.playerOneAiRb = new System.Windows.Forms.RadioButton();
            this.playerOneHumanRb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sticksNud = new System.Windows.Forms.NumericUpDown();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.gamePnl.SuspendLayout();
            this.playerTwoPnl.SuspendLayout();
            this.playerOnePnl.SuspendLayout();
            this.optionsPnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sticksNud)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePnl
            // 
            this.gamePnl.Controls.Add(this.sticksLbl);
            this.gamePnl.Controls.Add(this.label5);
            this.gamePnl.Controls.Add(this.playerTwoPnl);
            this.gamePnl.Controls.Add(this.label4);
            this.gamePnl.Controls.Add(this.playerOnePnl);
            this.gamePnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gamePnl.Location = new System.Drawing.Point(0, 151);
            this.gamePnl.Name = "gamePnl";
            this.gamePnl.Size = new System.Drawing.Size(624, 155);
            this.gamePnl.TabIndex = 1;
            // 
            // sticksLbl
            // 
            this.sticksLbl.AutoSize = true;
            this.sticksLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sticksLbl.Location = new System.Drawing.Point(263, 65);
            this.sticksLbl.Name = "sticksLbl";
            this.sticksLbl.Size = new System.Drawing.Size(105, 55);
            this.sticksLbl.TabIndex = 14;
            this.sticksLbl.Text = "100";
            // 
            // logLst
            // 
            this.logLst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logLst.FormattingEnabled = true;
            this.logLst.ItemHeight = 20;
            this.logLst.Location = new System.Drawing.Point(0, 306);
            this.logLst.Name = "logLst";
            this.logLst.Size = new System.Drawing.Size(624, 104);
            this.logLst.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Player Two";
            // 
            // playerTwoPnl
            // 
            this.playerTwoPnl.Controls.Add(this.playerTwoThreeStickBtn);
            this.playerTwoPnl.Controls.Add(this.playerTwoTwoStickBtn);
            this.playerTwoPnl.Controls.Add(this.playerTwoOneStickBtn);
            this.playerTwoPnl.Location = new System.Drawing.Point(439, 53);
            this.playerTwoPnl.Name = "playerTwoPnl";
            this.playerTwoPnl.Size = new System.Drawing.Size(156, 95);
            this.playerTwoPnl.TabIndex = 11;
            // 
            // playerTwoThreeStickBtn
            // 
            this.playerTwoThreeStickBtn.Location = new System.Drawing.Point(3, 67);
            this.playerTwoThreeStickBtn.Name = "playerTwoThreeStickBtn";
            this.playerTwoThreeStickBtn.Size = new System.Drawing.Size(150, 26);
            this.playerTwoThreeStickBtn.TabIndex = 13;
            this.playerTwoThreeStickBtn.Text = "Three Stick";
            this.playerTwoThreeStickBtn.UseVisualStyleBackColor = true;
            this.playerTwoThreeStickBtn.Click += new System.EventHandler(this.PickUpSticksbtn_Click);
            // 
            // playerTwoTwoStickBtn
            // 
            this.playerTwoTwoStickBtn.Location = new System.Drawing.Point(3, 35);
            this.playerTwoTwoStickBtn.Name = "playerTwoTwoStickBtn";
            this.playerTwoTwoStickBtn.Size = new System.Drawing.Size(150, 26);
            this.playerTwoTwoStickBtn.TabIndex = 12;
            this.playerTwoTwoStickBtn.Text = "Two Stick";
            this.playerTwoTwoStickBtn.UseVisualStyleBackColor = true;
            this.playerTwoTwoStickBtn.Click += new System.EventHandler(this.PickUpSticksbtn_Click);
            // 
            // playerTwoOneStickBtn
            // 
            this.playerTwoOneStickBtn.Location = new System.Drawing.Point(3, 3);
            this.playerTwoOneStickBtn.Name = "playerTwoOneStickBtn";
            this.playerTwoOneStickBtn.Size = new System.Drawing.Size(150, 26);
            this.playerTwoOneStickBtn.TabIndex = 11;
            this.playerTwoOneStickBtn.Text = "One Stick";
            this.playerTwoOneStickBtn.UseVisualStyleBackColor = true;
            this.playerTwoOneStickBtn.Click += new System.EventHandler(this.PickUpSticksbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Player One";
            // 
            // playerOnePnl
            // 
            this.playerOnePnl.Controls.Add(this.playerOneThreeStickBtn);
            this.playerOnePnl.Controls.Add(this.playerOneTwoStickBtn);
            this.playerOnePnl.Controls.Add(this.playerOneOneStickBtn);
            this.playerOnePnl.Location = new System.Drawing.Point(27, 55);
            this.playerOnePnl.Name = "playerOnePnl";
            this.playerOnePnl.Size = new System.Drawing.Size(156, 95);
            this.playerOnePnl.TabIndex = 9;
            // 
            // playerOneThreeStickBtn
            // 
            this.playerOneThreeStickBtn.Location = new System.Drawing.Point(3, 67);
            this.playerOneThreeStickBtn.Name = "playerOneThreeStickBtn";
            this.playerOneThreeStickBtn.Size = new System.Drawing.Size(150, 26);
            this.playerOneThreeStickBtn.TabIndex = 13;
            this.playerOneThreeStickBtn.Text = "Three Stick";
            this.playerOneThreeStickBtn.UseVisualStyleBackColor = true;
            this.playerOneThreeStickBtn.Click += new System.EventHandler(this.PickUpSticksbtn_Click);
            // 
            // playerOneTwoStickBtn
            // 
            this.playerOneTwoStickBtn.Location = new System.Drawing.Point(3, 35);
            this.playerOneTwoStickBtn.Name = "playerOneTwoStickBtn";
            this.playerOneTwoStickBtn.Size = new System.Drawing.Size(150, 26);
            this.playerOneTwoStickBtn.TabIndex = 12;
            this.playerOneTwoStickBtn.Text = "Two Stick";
            this.playerOneTwoStickBtn.UseVisualStyleBackColor = true;
            this.playerOneTwoStickBtn.Click += new System.EventHandler(this.PickUpSticksbtn_Click);
            // 
            // playerOneOneStickBtn
            // 
            this.playerOneOneStickBtn.Location = new System.Drawing.Point(3, 3);
            this.playerOneOneStickBtn.Name = "playerOneOneStickBtn";
            this.playerOneOneStickBtn.Size = new System.Drawing.Size(150, 26);
            this.playerOneOneStickBtn.TabIndex = 11;
            this.playerOneOneStickBtn.Text = "One Stick";
            this.playerOneOneStickBtn.UseVisualStyleBackColor = true;
            this.playerOneOneStickBtn.Click += new System.EventHandler(this.PickUpSticksbtn_Click);
            // 
            // optionsPnl
            // 
            this.optionsPnl.Controls.Add(this.label3);
            this.optionsPnl.Controls.Add(this.panel3);
            this.optionsPnl.Controls.Add(this.label2);
            this.optionsPnl.Controls.Add(this.panel6);
            this.optionsPnl.Controls.Add(this.label1);
            this.optionsPnl.Controls.Add(this.sticksNud);
            this.optionsPnl.Controls.Add(this.startGameBtn);
            this.optionsPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.optionsPnl.Location = new System.Drawing.Point(0, -7);
            this.optionsPnl.Name = "optionsPnl";
            this.optionsPnl.Size = new System.Drawing.Size(624, 158);
            this.optionsPnl.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Player Two";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.playerTwoAiRb);
            this.panel3.Controls.Add(this.playerTwoHumanRb);
            this.panel3.Location = new System.Drawing.Point(440, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 71);
            this.panel3.TabIndex = 14;
            // 
            // playerTwoAiRb
            // 
            this.playerTwoAiRb.AutoSize = true;
            this.playerTwoAiRb.Location = new System.Drawing.Point(19, 38);
            this.playerTwoAiRb.Name = "playerTwoAiRb";
            this.playerTwoAiRb.Size = new System.Drawing.Size(43, 24);
            this.playerTwoAiRb.TabIndex = 1;
            this.playerTwoAiRb.TabStop = true;
            this.playerTwoAiRb.Text = "AI";
            this.playerTwoAiRb.UseVisualStyleBackColor = true;
            // 
            // playerTwoHumanRb
            // 
            this.playerTwoHumanRb.AutoSize = true;
            this.playerTwoHumanRb.Location = new System.Drawing.Point(19, 8);
            this.playerTwoHumanRb.Name = "playerTwoHumanRb";
            this.playerTwoHumanRb.Size = new System.Drawing.Size(79, 24);
            this.playerTwoHumanRb.TabIndex = 0;
            this.playerTwoHumanRb.TabStop = true;
            this.playerTwoHumanRb.Text = "Human";
            this.playerTwoHumanRb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Player One";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.playerOneAiRb);
            this.panel6.Controls.Add(this.playerOneHumanRb);
            this.panel6.Location = new System.Drawing.Point(28, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(156, 71);
            this.panel6.TabIndex = 12;
            // 
            // playerOneAiRb
            // 
            this.playerOneAiRb.AutoSize = true;
            this.playerOneAiRb.Location = new System.Drawing.Point(19, 38);
            this.playerOneAiRb.Name = "playerOneAiRb";
            this.playerOneAiRb.Size = new System.Drawing.Size(43, 24);
            this.playerOneAiRb.TabIndex = 1;
            this.playerOneAiRb.TabStop = true;
            this.playerOneAiRb.Text = "AI";
            this.playerOneAiRb.UseVisualStyleBackColor = true;
            // 
            // playerOneHumanRb
            // 
            this.playerOneHumanRb.AutoSize = true;
            this.playerOneHumanRb.Location = new System.Drawing.Point(19, 8);
            this.playerOneHumanRb.Name = "playerOneHumanRb";
            this.playerOneHumanRb.Size = new System.Drawing.Size(79, 24);
            this.playerOneHumanRb.TabIndex = 0;
            this.playerOneHumanRb.TabStop = true;
            this.playerOneHumanRb.Text = "Human";
            this.playerOneHumanRb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number Of Sticks (10 - 100)";
            // 
            // sticksNud
            // 
            this.sticksNud.Location = new System.Drawing.Point(349, 11);
            this.sticksNud.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sticksNud.Name = "sticksNud";
            this.sticksNud.Size = new System.Drawing.Size(120, 26);
            this.sticksNud.TabIndex = 10;
            this.sticksNud.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(245, 111);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(129, 37);
            this.startGameBtn.TabIndex = 9;
            this.startGameBtn.Text = "Start Game";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // pickUpSticksFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 410);
            this.Controls.Add(this.optionsPnl);
            this.Controls.Add(this.gamePnl);
            this.Controls.Add(this.logLst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pickUpSticksFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick Up Sticks";
            this.Load += new System.EventHandler(this.pickUpSticksFrm_Load);
            this.gamePnl.ResumeLayout(false);
            this.gamePnl.PerformLayout();
            this.playerTwoPnl.ResumeLayout(false);
            this.playerOnePnl.ResumeLayout(false);
            this.optionsPnl.ResumeLayout(false);
            this.optionsPnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sticksNud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel gamePnl;
        private System.Windows.Forms.Label sticksLbl;
        private System.Windows.Forms.ListBox logLst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel playerTwoPnl;
        private System.Windows.Forms.Button playerTwoThreeStickBtn;
        private System.Windows.Forms.Button playerTwoTwoStickBtn;
        private System.Windows.Forms.Button playerTwoOneStickBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel playerOnePnl;
        private System.Windows.Forms.Button playerOneThreeStickBtn;
        private System.Windows.Forms.Button playerOneTwoStickBtn;
        private System.Windows.Forms.Button playerOneOneStickBtn;
        private System.Windows.Forms.Panel optionsPnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton playerTwoAiRb;
        private System.Windows.Forms.RadioButton playerTwoHumanRb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton playerOneAiRb;
        private System.Windows.Forms.RadioButton playerOneHumanRb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sticksNud;
        private System.Windows.Forms.Button startGameBtn;
    }
}

