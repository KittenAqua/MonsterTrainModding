using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MonsterTrainModding;
using MonsterTrainTestMod.Clans;
using Trainworks.Builders;
using Trainworks.Constants;

namespace MonsterTrainTestMod.SpellCards
{
    class NotHornBreak
    {
        public static readonly string ID = TestPlugin.GUID + "_NotHornBreak";

        public static void BuildAndRegister()
        {
            new CardDataBuilder
            {
                CardID = ID,
                Name = "Not Horn Break",
                Description = "Deal [effect0.power] damage",
                Cost = 1,
                Rarity = CollectableRarity.Common,
                TargetsRoom = true,
                Targetless = false,
                ClanID = TestClan.ID,
                AssetPath = "assets/nothornbreak.png",
                CardPoolIDs = new List<string> { VanillaCardPoolIDs.MegaPool },
                EffectBuilders = new List<CardEffectDataBuilder>
                {
                    new CardEffectDataBuilder
                    {
                        EffectStateType = VanillaCardEffectTypes.CardEffectDamage,
                        ParamInt = 5,
                        TargetMode = TargetMode.DropTargetCharacter
                    }
                },
                TraitBuilders = new List<CardTraitDataBuilder>
                {
                    new CardTraitDataBuilder
                    {
                        TraitStateType = VanillaCardTraitTypes.CardTraitIgnoreArmor
                    }
                }
            }.BuildAndRegister();
        }
    }
}
