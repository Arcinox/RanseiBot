using System;
using System.Collections.Generic;
using System.Text;

namespace RanseiBeta
{
    public class DiceRoller : IDiceRoller
    {
        //public DiceRoller()
        //{

        //}

        public int RollD6()
        {
            return RollDice(6);
        }

        public int RollDice(int max)
        {
            return RollDice(1, max);
        }

        public int RollDice(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
