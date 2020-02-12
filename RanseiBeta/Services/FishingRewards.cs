using System;
using System.Collections.Generic;
using System.Text;
using static RanseiBeta.Enums;

namespace RanseiBeta
{
    public class FishingRewards
    {
        public RanseiEvent FishingEvent { get; set; }
        public Dictionary<int, Reward> Rewards { get; set; }

        public FishingRewards(RanseiEvent fishEvent)
        {
            FishingEvent = fishEvent;
            InitialiseRewardsList();
        }

        private void InitialiseRewardsList()
        {
            switch (FishingEvent)
            {
                case RanseiEvent.Halloween2019: Rewards = GetHalloweenFishingRewards(); break;
                case RanseiEvent.RanseiVSGalar: Rewards = GetRanseiVSGalarFishingRewards(); break;
                default: Rewards = GetStandardFishingRewards(); break;
            }
        }

        private Dictionary<int, Reward> GetStandardFishingRewards()
        {
            Dictionary<int, Reward> rewardsList = new Dictionary<int, Reward>();

            #region Pokemon Rewards
            #region Kanto
            rewardsList.Add(1, new Pokemon("Squirtle", Region.Kanto, 7, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(2, new Pokemon("Psyduck", Region.Kanto, 54, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(3, new Pokemon("Poliwag", Region.Kanto, 60, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(4, new Pokemon("Tentacool", Region.Kanto, 72, new List<ElementalType> { ElementalType.Water, ElementalType.Poison }));
            //slowpoke should be here : rewardsList.Add( , new Pokemon("Slowpoke", Region.Kanto, 79, new List<ElementalType> { ElementalType.Water, ElementalType.Psychic }));
            rewardsList.Add(5, new Pokemon("Seel", Region.Kanto, 86, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(6, new Pokemon("Shellder", Region.Kanto, 90, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(7, new Pokemon("Krabby", Region.Kanto, 98, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(8, new Pokemon("Horsea", Region.Kanto, 116, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(9, new Pokemon("Goldeen", Region.Kanto, 118, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(10, new Pokemon("Staryu", Region.Kanto, 120, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(11, new Pokemon("Magikarp", Region.Kanto, 129, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(12, new Pokemon("Lapras", Region.Kanto, 131, new List<ElementalType> { ElementalType.Water, ElementalType.Ice }));
            //add Omanyte : rewardsList.Add( , new Pokemon("Omanyte", Region.Kanto, 138, new List<ElementalType> { ElementalType.Rock, ElementalType.Water }));
            //add Kabuto : rewardsList.Add( , new Pokemon("Kabuto", Region.Kanto, 140, new List<ElementalType> { ElementalType.Rock, ElementalType.Water }));
            #endregion

            #region Johto
            rewardsList.Add(13, new Pokemon("Totodile", Region.Johto, 158, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(14, new Pokemon("Chinchou", Region.Johto, 170, new List<ElementalType> { ElementalType.Water, ElementalType.Electric }));
            rewardsList.Add(15, new Pokemon("Marill", Region.Johto, 183, new List<ElementalType> { ElementalType.Water, ElementalType.Fairy }));
            rewardsList.Add(16, new Pokemon("Wooper", Region.Johto, 194, new List<ElementalType> { ElementalType.Water, ElementalType.Ground }));
            rewardsList.Add(17, new Pokemon("Qwilfish", Region.Johto, 211, new List<ElementalType> { ElementalType.Water, ElementalType.Poison }));
            rewardsList.Add(18, new Pokemon("Corsola", Region.Johto, 222, new List<ElementalType> { ElementalType.Water, ElementalType.Rock }));
            rewardsList.Add(19, new Pokemon("Remoraid", Region.Johto, 223, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(20, new Pokemon("Mantine", Region.Johto, 226, new List<ElementalType> { ElementalType.Water, ElementalType.Flying }));
            #endregion

            #region Hoenn
            rewardsList.Add(21, new Pokemon("Mudkip", Region.Hoenn, 258, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(22, new Pokemon("Lotad", Region.Hoenn, 270, new List<ElementalType> { ElementalType.Water, ElementalType.Grass }));
            rewardsList.Add(23, new Pokemon("Wingull", Region.Hoenn, 278, new List<ElementalType> { ElementalType.Water, ElementalType.Flying }));
            rewardsList.Add(24, new Pokemon("Surskit", Region.Hoenn, 283, new List<ElementalType> { ElementalType.Bug, ElementalType.Water }));
            rewardsList.Add(25, new Pokemon("Carvanha", Region.Hoenn, 318, new List<ElementalType> { ElementalType.Water, ElementalType.Dark }));
            rewardsList.Add(26, new Pokemon("Wailmer", Region.Hoenn, 320, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(27, new Pokemon("Barboach", Region.Hoenn, 339, new List<ElementalType> { ElementalType.Water, ElementalType.Ground }));
            rewardsList.Add(28, new Pokemon("Corphish", Region.Hoenn, 341, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(29, new Pokemon("Feebas", Region.Hoenn, 349, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(30, new Pokemon("Spheal", Region.Hoenn, 363, new List<ElementalType> { ElementalType.Ice, ElementalType.Water }));
            rewardsList.Add(31, new Pokemon("Clamperl", Region.Hoenn, 366, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(32, new Pokemon("Relicanth", Region.Hoenn, 369, new List<ElementalType> { ElementalType.Water, ElementalType.Rock }));
            rewardsList.Add(33, new Pokemon("Luvdisc", Region.Hoenn, 370, new List<ElementalType> { ElementalType.Water }));
            #endregion

            #region Sinnoh
            rewardsList.Add(34, new Pokemon("Piplup", Region.Sinnoh, 393, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(35, new Pokemon("Buizel", Region.Sinnoh, 418, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(36, new Pokemon("Shellos", Region.Sinnoh, 422, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(37, new Pokemon("Finneon", Region.Sinnoh, 456, new List<ElementalType> { ElementalType.Water }));
            #endregion

            #region Unova
            rewardsList.Add(38, new Pokemon("Oshawott", Region.Unova, 501, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(39, new Pokemon("Panpour", Region.Unova, 515, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(40, new Pokemon("Tympole", Region.Unova, 535, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(41, new Pokemon("Basculin", Region.Unova, 550, new List<ElementalType> { ElementalType.Water }));
            //add Tirtouga : rewardsList.Add( , new Pokemon("Tirtouga", Region.Unova, 564, new List<ElementalType> { ElementalType.Water, ElementalType.Rock }));
            rewardsList.Add(42, new Pokemon("Ducklett", Region.Unova, 580, new List<ElementalType> { ElementalType.Water, ElementalType.Flying }));
            rewardsList.Add(43, new Pokemon("Frillish", Region.Unova, 592, new List<ElementalType> { ElementalType.Water, ElementalType.Ghost }));
            rewardsList.Add(44, new Pokemon("Alomomola", Region.Unova, 594, new List<ElementalType> { ElementalType.Water }));
            #endregion

            #region Kalos
            rewardsList.Add(45, new Pokemon("Froakie", Region.Kalos, 656, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(46, new Pokemon("Binacle", Region.Kalos, 688, new List<ElementalType> { ElementalType.Rock, ElementalType.Water }));
            rewardsList.Add(47, new Pokemon("Skrelp", Region.Kalos, 690, new List<ElementalType> { ElementalType.Poison, ElementalType.Water }));
            rewardsList.Add(48, new Pokemon("Clauncher", Region.Kalos, 692, new List<ElementalType> { ElementalType.Water }));
            #endregion

            #region Alola
            rewardsList.Add(49, new Pokemon("Popplio", Region.Alola, 728, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(50, new Pokemon("Wishiwashi", Region.Alola, 746, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(51, new Pokemon("Mareanie", Region.Alola, 747, new List<ElementalType> { ElementalType.Poison, ElementalType.Water }));
            rewardsList.Add(52, new Pokemon("Dewpider", Region.Alola, 751, new List<ElementalType> { ElementalType.Water, ElementalType.Bug }));
            rewardsList.Add(53, new Pokemon("Wimpod", Region.Alola, 767, new List<ElementalType> { ElementalType.Bug, ElementalType.Water }));
            rewardsList.Add(54, new Pokemon("Pyukumuku", Region.Alola, 771, new List<ElementalType> { ElementalType.Water }));
            rewardsList.Add(55, new Pokemon("Bruxish", Region.Alola, 779, new List<ElementalType> { ElementalType.Water, ElementalType.Psychic }));
            #endregion
            #endregion

            #region Item Rewards
            for (int i = 56; i <= 66; i++)
            {
                rewardsList.Add(i, new Item("Heart Scale"));
            }

            for (int i = 67; i <= 77; i++)
            {
                rewardsList.Add(i, new Item("Beach Glass"));
            }

            for (int i = 78; i <= 88; i++)
            {
                rewardsList.Add(i, new Item("Water Stone"));
            }

            for (int i = 89; i <= 95; i++)
            {
                rewardsList.Add(i, new Item("Big Pearl"));
            }

            for (int i = 96; i <= 97; i++)
            {
                rewardsList.Add(i, new Item("Pokemon Egg"));
            }

            rewardsList.Add(98, new Item("Poke Doll"));

            for (int i = 99; i <= 100; i++)
            {
                rewardsList.Add(i, new Item("Big Nugget"));
            }
#endregion

            return rewardsList;
        }

        private Dictionary<int, Reward> GetHalloweenFishingRewards()
        {
            throw new NotImplementedException("We don't have the Halloween 2019 prize list yet!");
        }

        private Dictionary<int, Reward> GetRanseiVSGalarFishingRewards()
        {
            throw new NotImplementedException("We don't have the Ransei vs Galar prize list yet!");
        }

        //public string GetFishingReward(int numberRolled)
        //{
        //    string reward = string.Empty;
        //    if (Rewards != null && Rewards.Count > 0 && Rewards.ContainsKey(numberRolled))
        //    {
        //        Rewards.TryGetValue(numberRolled, out reward);
        //    }

        //    if (string.IsNullOrEmpty(reward))
        //    {
        //        reward = "Prize could not be found! Please try again.";
        //    }

        //    return reward;
        //}

        public Reward GetFishingReward(int numberRolled)
        {
            //var test = new Test123<string>();
            //string reward = string.Empty;
            //if (Rewards != null && Rewards.Count > 0 && Rewards.ContainsKey(numberRolled))
            //{
            //    Rewards.TryGetValue(numberRolled, out reward);
            //}

            //if (string.IsNullOrEmpty(reward))
            //{
            //    reward = "Prize could not be found! Please try again.";
            //}
            if (Rewards.ContainsKey(numberRolled))
            {
                return Rewards[numberRolled];
            }

            return null;
        }
    }
}
