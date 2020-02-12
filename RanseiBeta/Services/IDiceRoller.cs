using System;
using System.Collections.Generic;
using System.Text;

namespace RanseiBeta
{
    public interface IDiceRoller
    {
        int RollD6();
        int RollDice(int max);
        int RollDice(int min, int max);
    }
}
