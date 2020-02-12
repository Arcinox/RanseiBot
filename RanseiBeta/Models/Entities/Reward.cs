using System;
using System.Collections.Generic;
using System.Text;
using static RanseiBeta.Enums;

namespace RanseiBeta
{
    public abstract class Reward
    {
        public string Name { get; protected set; }

        //virtual methods which can be implemented or overridden
    }
}
