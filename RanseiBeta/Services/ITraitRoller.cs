using static RanseiBeta.Enums;

namespace RanseiBeta
{
    public interface ITraitRoller
    {
        bool IsTraited();
        Trait RollTrait();
    }
}