using System;
using System.Collections.Generic;
using System.Text;
using static RanseiBeta.Enums;

namespace RanseiBeta
{
    public interface ITraitable
    {
        Trait? Trait { get; }
        void RollTrait();
    }
}
