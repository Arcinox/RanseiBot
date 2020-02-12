using System;
using System.Collections.Generic;
using System.Text;
using static RanseiBeta.Enums;

namespace RanseiBeta
{
    public class TraitRoller : ITraitRoller
    {
        private readonly IDiceRoller diceRoller;

        //public TraitRoller(IDiceRoller diceRoller) //when dependency injection is working
        //{
        //    this.diceRoller = diceRoller;
        //}

        public TraitRoller()
        {
            diceRoller = new DiceRoller();
        }

        public bool IsTraited()
        {
            int numberRolled = diceRoller.RollDice(100); //could pass in the odds instead (TraitStatistics??)
            if (numberRolled <= 10)
            {
                return true;
            }

            return false;
        }

        public Trait RollTrait()
        {
            Trait rolledTrait = Trait.Basic;
            if (IsTraited())
            {
                int traitRolled = diceRoller.RollDice(5); //skip 0 to omit Basic trait
                Enum.TryParse(traitRolled.ToString(), out rolledTrait);
                return rolledTrait;
            }

            return rolledTrait;
        }
    }
}
