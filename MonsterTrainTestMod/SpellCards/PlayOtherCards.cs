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
    class PlayOtherCards
    {
        public static readonly string ID = TestPlugin.GUID + "_PlayOtherCards";

        public static void BuildAndRegister()
        {
            new CardDataBuilder
            {
                CardID = ID,
                Name = "Play Other Cards",
                Description = "Give a friendly unit +<nobr>{[trait0.power]}<sprite name=\"Attack\"></nobr> for each card played this battle.",
                Cost = 2,
                Rarity = CollectableRarity.Rare,
                TargetsRoom = true,
                Targetless = false,
                ClanID = TestClan.ID,
                AssetPath = "assets/playothercards.png",
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateName = VanillaCardTraitTypes.CardTraitScalingBuffDamage.AssemblyQualifiedName,
                        ParamTrackedValue = CardStatistics.TrackedValueType.AnyCardPlayed,
                        ParamEntryDuration = CardStatistics.EntryDuration.ThisBattle,
                        ParamInt = 2,
                        ParamTeamType = Team.Type.Monsters
                    }
                },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectBuffDamage,
                        TargetMode = TargetMode.DropTargetCharacter,
                        TargetTeamType = Team.Type.Monsters
                    }
                }
            }.BuildAndRegister();
        }
    }
}
