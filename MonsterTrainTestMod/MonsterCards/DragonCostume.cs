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
    class DragonCostume
    {
        public static readonly string ID = TestPlugin.GUID + "_DragonCostumeCard";
        public static readonly string CharID = TestPlugin.GUID + "_DragonCostumeCharacter";

        public static void BuildAndRegister()
        {
            var dragonCostumeCharacter = new CharacterDataBuilder
            {
                CharacterID = CharID,
                Name = "Dragon Costume",
                Size = 5,
                Health = 50,
                AttackDamage = 5,
                AssetPath = "assets/dragoncostume_character.png",
                SubtypeKeys = new List<string> { SubtypeDragon.Key },
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnHit,
                        Description = "Gain <nobr><b>Damage Shield</b> <b>{[effect0.status0.power]}</b></nobr>",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                                TargetMode = TargetMode.Self,
                                TargetTeamType = Team.Type.Monsters,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        count = 1,
                                        statusId = VanillaStatusEffectIDs.DamageShield
                                    }
                                }
                            }
                        }
                    }
                }
            };

            new CardDataBuilder
            {
                CardID = ID,
                Name = "Dragon Costume",
                Cost = 2,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "assets/dragoncostume.png",
                ClanID = TestClan.ID,
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.StygianBanner, VanillaCardPoolIDs.UnitsAllBanner },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateName = "CardEffectSpawnMonster",
                        TargetMode = TargetMode.DropTargetCharacter,
                        ParamCharacterDataBuilder = dragonCostumeCharacter
                    }
                }
            }.BuildAndRegister();
        }
    }
}
