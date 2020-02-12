using System;
using System.Collections.Generic;
using System.Text;
using static RanseiBeta.Enums;

namespace RanseiBeta
{
    public class Pokemon : Reward, ITraitable
    {
        private readonly ITraitRoller traitRoller;
        #region Constructors
        public Pokemon()
        {
            traitRoller = new TraitRoller();
        }

        //public Pokemon(ITraitRoller traitRoller)
        //{
        //    this.traitRoller = traitRoller;
        //}


        public Pokemon(string name, Region region, int dexNo, List<ElementalType> types)
            : this()
        {
            Name = name;
            Region = region;
            NationalDexNumber = dexNo;
            ElementalTypes = types;
            Classification = PokemonClassification.Standard;
        }

        public Pokemon(string name, Region region, int dexNo, List<ElementalType> types, PokemonClassification classification)
            : this(name, region, dexNo, types)
        {
            Classification = classification;
        }
        #endregion

        #region IPokemon Implementation
        public Region Region { get; }

        public int NationalDexNumber { get; }

        public List<ElementalType> ElementalTypes { get; }

        public PokemonClassification Classification { get; }

        public Trait? Trait { get; private set; }
        #endregion

        #region Overridden Methods
        public void RollTrait()
        {
            Trait = traitRoller.RollTrait();
        }
        #endregion
    }
}
