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

namespace MonsterTrainTestMod.MonsterCards
{
    class AppleMorsel
    {
        public static readonly string ID = TestPlugin.GUID + "_AppleMorselCard";
        public static readonly string CharID = TestPlugin.GUID + "_AppleMorselCharacter";

        public static void BuildAndRegister()
        {
            var appleMorselCharacter = new CharacterDataBuilder
            {
                CharacterID = CharID,
                Name = "Apple Morsel",
                Size = 1,
                Health = 1,
                AttackDamage = 0,
                AssetPath = "assets/applemorsel_character.png",
                SubtypeKeys = new List<string> { "SubtypesData_Snack" },
                PriorityDraw = false,
                TriggerBuilders = new List<CharacterTriggerDataBuilder>
                {
                    new CharacterTriggerDataBuilder
                    {
                        Trigger = CharacterTriggerData.Trigger.OnEaten,
                        Description = "Eater takes {[effect1.power]} damage and gains <nobr><b>Rage</b> <b>{[effect0.status0.power]}</b></nobr>",
                        EffectBuilders = new List<CardEffectDataBuilder>
                        {
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                ParamStatusEffects = new StatusEffectStackData[]
                                {
                                    new StatusEffectStackData
                                    {
                                        statusId = VanillaStatusEffectIDs.Rage,
                                        count = 3
                                    }
                                }
                            },
                            new CardEffectDataBuilder
                            {
                                EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                                TargetMode = TargetMode.LastFeederCharacter,
                                TargetTeamType = Team.Type.Monsters,
                                ParamInt = 5
                            }
                        }
                    }
                }
            };

            new CardDataBuilder
            {
                CardID = ID,
                Name = "Apple Morsel",
                Cost = 0,
                CardType = CardType.Monster,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                AssetPath = "assets/applemorsel.png",
                ClanID = VanillaClanIDs.Umbra,
                CardPoolIDs = new List<string>
                {
                    VanillaCardPoolIDs.MorselPool, VanillaCardPoolIDs.MorselPool,
                    VanillaCardPoolIDs.MorselPool, VanillaCardPoolIDs.MorselPool,
                    VanillaCardPoolIDs.MorselPool, VanillaCardPoolIDs.MorselPool,
                    VanillaCardPoolIDs.MorselPool, VanillaCardPoolIDs.MorselPool,
                    VanillaCardPoolIDs.MorselPool, VanillaCardPoolIDs.MorselPool,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter,
                    VanillaCardPoolIDs.MorselPoolStarter, VanillaCardPoolIDs.MorselPoolStarter
                },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectSpawnMonster,
                        TargetMode = TargetMode.DropTargetCharacter,
                        ParamCharacterDataBuilder = appleMorselCharacter
                    }
                }
            }.BuildAndRegister();
        }
    }
}
