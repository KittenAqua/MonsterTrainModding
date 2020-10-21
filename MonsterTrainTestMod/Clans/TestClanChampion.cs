using MonsterTrainModding;
using MonsterTrainTestMod.MonsterCards;
using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Builders;
using Trainworks.Constants;
using Trainworks.Managers;

namespace MonsterTrainTestMod.Clans
{
    class TestClanChampion
    {
        public static readonly string ID = TestPlugin.GUID + "_TestClanChampion";
        public static readonly string CharID = TestPlugin.GUID + "_TestClanChampionCharacter";

        public static void BuildAndRegister()
        {
            var championCharacterBuilder = new CharacterDataBuilder
            {
                CharacterID = CharID,
                Name = "K.Aqua",
                Size = 1,
                Health = 10,
                AttackDamage = 5,
                AssetPath = "assets/kaqua_character.png"
            };

            new ChampionCardDataBuilder()
            {
                Champion = championCharacterBuilder,
                ChampionIconPath = "assets/kaqua.png",
                StarterCardData = CustomCardManager.GetCardDataByID(VanillaCardIDs.AlphaFiend),
                CardID = ID,
                Name = "K.Aqua",
                ClanID = TestClan.ID,
                AssetPath = "assets/kaqua.png"
            }.BuildAndRegister();
        }
    }
}
