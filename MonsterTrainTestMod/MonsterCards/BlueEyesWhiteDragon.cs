using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using Trainworks.Builders;
using Trainworks.Managers;
using Trainworks.Constants;
using System.Linq;
using UnityEngine;
using Trainworks.Utilities;
using MonsterTrainModding;
using MonsterTrainTestMod.Clans;

namespace MonsterTrainTestMod.MonsterCards
{
    class BlueEyesWhiteDragon
    {
        public static readonly string ID = TestPlugin.GUID + "_BlueEyesCard";
        public static readonly string CharID = TestPlugin.GUID + "_BlueEyesCharacter";

        public static void BuildAndRegister()
        {
            new CardDataBuilder
            {
                CardID = ID,
                Name = "Blue-Eyes White Dragon",
                Cost = 3,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "assets/blueeyes.png",
                ClanID = TestClan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.StygianBanner, VanillaCardPoolIDs.UnitsAllBanner },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                        TargetMode = TargetMode.DropTargetCharacter,
                        ParamCharacterDataBuilder = new CharacterDataBuilder
                        {
                            CharacterID = CharID,
                            Name = "Blue-Eyes White Dragon",
                            Size = 5,
                            Health = 2500,
                            AttackDamage = 3000,
                            AssetPath = "assets/blueeyes_character.png",
                            SubtypeKeys = new List<string> { SubtypeDragon.Key }
                        }
                    }
                }
            }.BuildAndRegister();
        }
    }
}
