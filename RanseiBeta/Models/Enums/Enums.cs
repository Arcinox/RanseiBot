using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RanseiBeta
{
    public class Enums
    {
        public enum Region
        {
            [Description("Unknown")]
            Unknown = 0,
            [Description("Kanto")]
            Kanto = 1,
            [Description("Johto")]
            Johto = 2,
            [Description("Hoenn")]
            Hoenn = 3,
            [Description("Sinnoh")]
            Sinnoh = 4,
            [Description("Unova")]
            Unova = 5,
            [Description("Kalos")]
            Kalos = 6,
            [Description("Alola")]
            Alola = 7,
            [Description("Galar")]
            Galar = 8,
            Oblivia = 96, //split these out into a different enum?
            Almia = 97,
            Fiore = 98,
            Orre = 99
        }

        public enum Trait
        {
            [Description("Basic")]
            Basic = 0,
            [Description("Shiny")]
            Shiny = 1,
            [Description("Albino")]
            Albino = 2,
            [Description("Melanistic")]
            Melanistic = 3,
            [Description("Pinkan")]
            Pinkan = 4,
            [Description("Erythristic")]
            Erythristic = 5
        }

        public enum RanseiEvent
        {
            [Description("None")]
            None = 0,
            [Description("Halloween 2019")]
            Halloween2019 = 1,
            [Description("Ransei VS Galar")]
            RanseiVSGalar = 2
        }

        public enum ElementalType
        {
            Unknown = 0,
            Normal = 1,
            Fire = 2,
            Water = 3,
            Electric = 4,
            Grass = 5,
            Ice = 6,
            Fighting = 7,
            Poison = 8,
            Ground = 9,
            Flying = 10,
            Psychic = 11,
            Bug = 12,
            Rock = 13,
            Ghost = 14,
            Dragon = 15,
            Dark = 16,
            Steel = 17,
            Fairy = 18
        }

        public enum PokemonClassification
        {
            Unknown = 0,
            Standard = 1,
            Mythical = 2,
            Legendary = 3
        }
    }
}
