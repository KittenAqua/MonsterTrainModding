﻿using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using MonsterTrainModdingAPI.Builders;
using MonsterTrainModdingAPI.Managers;
using MonsterTrainModdingAPI.Enums.MTCardPools;
using MonsterTrainModdingAPI.Enums.MTClans;
using MonsterTrainModdingAPI.Enums;

namespace MonsterTrainTestMod.SamplePatches
{
    class WimpcicleDataCreator
    {
        public static void RegisterRelic()
        {
            CardPool cardPool = new CardPool();
            var cardDataList = (Malee.ReorderableArray<CardData>)AccessTools.Field(typeof(CardPool), "cardDataList").GetValue(cardPool);
            var trainSteward = CustomCardManager.SaveManager.GetAllGameData().FindCardData("d14a50f3-728d-43e1-87f0-ef1b013f6678");
            cardDataList.Add(trainSteward);

            new CollectableRelicDataBuilder
            {
                CollectableRelicID = "AddTrainStewardToHand",
                Name = "Wimp-cicle",
                Description = "At the start of your turn, add a Train Steward to your hand",
                AssetPath = "netstandard2.0/wimpcicle.png",
                EffectBuilders = new List<RelicEffectDataBuilder>
                {
                    new RelicEffectDataBuilder
                    {
                        RelicEffectClassName = "RelicEffectAddBattleCardToHand",
                        ParamInt = 1,
                        ParamCardPool = cardPool,
                        ParamTrigger = CharacterTriggerData.Trigger.PreCombat,
                        ParamTargetMode = TargetMode.FrontInRoom
                    }
                },
                Rarity = CollectableRarity.Common
            }.BuildAndRegister();
        }
    }
}
