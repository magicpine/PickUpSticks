using System;
using System.Collections.Generic;
using System.Linq;

namespace PickUpSticks
{
    class AI
    {
        private Dictionary<decimal, List<int>> _AILearning;
        private Dictionary<decimal, List<int>> _CurrentGame;

        public AI(decimal numberOfSticks)
        {
            _AILearning = new Dictionary<decimal, List<int>>();
            _CurrentGame = new Dictionary<decimal, List<int>>();
            for (int i = 0; i < numberOfSticks; i++)
            {
                if (i == 0)
                    _AILearning.Add(i + 1, new List<int> { 1 });
                else if (i == 1)
                    _AILearning.Add(i + 1, new List<int> { 1,2 });
                else
                    _AILearning.Add(i + 1, new List<int> { 1, 2, 3 });
            }
        }

        internal int PickUpSticks(decimal numberOfSticksLeft)
        {
            int numberPickedUp = 0;
            //Get the List of numbers for the turn
            var myKey = _AILearning.First(x => x.Key == numberOfSticksLeft);
            //Get the Values from that list
            Random rng = new Random();
            //CHECK FOR The number of sticks left 
            //Find which index to choose
            int index = rng.Next(myKey.Value.Count);
            //find the Number to remove
            numberPickedUp = _AILearning.First(x => x.Key == numberOfSticksLeft).Value[index];
            //Remove it from the list it to the list Again
            _AILearning.First(x => x.Key == numberOfSticksLeft).Value.RemoveAt(index);
            //Add it to the Current Game so we can figure it out if they win or lose
            _CurrentGame.Add(numberOfSticksLeft, new List<int> { numberPickedUp, numberPickedUp });
            return numberPickedUp;
        }

        internal void SeedInLearning(bool shouldTheAILearn)
        {
            if (shouldTheAILearn)
            {
                //Add the number * 2 back into the value for that key
                foreach (var item in _CurrentGame)
                {
                    _AILearning.First(x => x.Key == item.Key).Value.AddRange(item.Value);
                }
            }
            else
            {
                foreach (var item in _AILearning)
                {
                    if (item.Key == 1)
                    {
                        if (!item.Value.Contains(1))
                            item.Value.Add(1);
                    }
                    else if (item.Key == 2)
                    {
                        if (!item.Value.Contains(2))
                            item.Value.Add(2);

                        if (!item.Value.Contains(1))
                            item.Value.Add(1);
                    }
                    else
                    {
                        for (int i = 1; i < 4; i++)
                        {
                            if (!item.Value.Contains(i))
                                item.Value.Add(i);
                        }
                    }
                }
                _CurrentGame = null;
            }
        }

        internal void NewGame(decimal numberOfSticks)
        {
            _CurrentGame = new Dictionary<decimal, List<int>>();
            if (_AILearning.Count < numberOfSticks)
            {
                decimal addNewitems = numberOfSticks - _AILearning.Count;
                int lastCount = _AILearning.Count;
                for (int i = 1; i < addNewitems + 1; i++)
                {

                    _AILearning.Add(i + lastCount, new List<int> { 1, 2, 3 });
                }
            }
        }
    }
}
