using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MonsterTrainModding;
using MonsterTrainTestMod.Clans;
using Trainworks.Builders;
using Trainworks.Constants;
using Trainworks.Enums;

namespace MonsterTrainTestMod.SpellCards
{
    class GiveEveryoneArmor
    {
        public static readonly string ID = TestPlugin.GUID + "_GiveEveryoneArmor";

        public static void BuildAndRegister()
        {
            new CardDataBuilder
            {
                CardID = ID,
                Name = "Give Everyone Armor",
                Description = "Give everyone <nobr><b>Armor</b> <b>{[effect0.status0.power]}</b></nobr>.",
                Cost = 0,
                Rarity = CollectableRarity.Uncommon,
                TargetsRoom = true,
                Targetless = true,
                ClanID = TestClan.ID,
                AssetPath = "assets/giveeveryonearmor.png",
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectAddStatusEffect,
                        TargetMode = TargetMode.Room,
                        TargetTeamType = Team.Type.Monsters | Team.Type.Heroes,
                        ParamStatusEffects = new StatusEffectStackData[]
                        {
                            new StatusEffectStackData
                            {
                                statusId = VanillaStatusEffectIDs.Armor,
                                count = 2
                            }
                        }
                    }
                }
            }.BuildAndRegister();
        }
    }
}
