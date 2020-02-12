using System;
using System.Collections.Generic;
using System.Text;
using static RanseiBeta.Enums;

namespace RanseiBeta
{
    public class TraitedItem : Item, ITraitable
    {
        public Trait? Trait { get; protected set; }

        public TraitedItem(string name) : base(name) { }

        //virtual methods which can be implemented or overridden
        public virtual void RollTrait() { }
    }
}
