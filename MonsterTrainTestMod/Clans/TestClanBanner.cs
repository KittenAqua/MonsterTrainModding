using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using Trainworks.Builders;
using Trainworks.Managers;
using Trainworks.Enums;
using MonsterTrainModding;
using MonsterTrainTestMod.MonsterCards;
using Trainworks.Constants;

namespace MonsterTrainTestMod.Clans
{
    class TestClanBanner
    {
        public static readonly string ID = TestClan.ID + "Banner";
        public static readonly string RewardID = TestClan.ID + "BannerReward";

        public static void BuildAndRegister()
        {
            CardPool cardPool = UnityEngine.ScriptableObject.CreateInstance<CardPool>();
            var cardDataList = (Malee.ReorderableArray<CardData>)AccessTools.Field(typeof(CardPool), "cardDataList").GetValue(cardPool);
            cardDataList.Add(CustomCardManager.GetCardDataByID(BlueEyesWhiteDragon.ID));
            cardDataList.Add(CustomCardManager.GetCardDataByID(DragonCostume.ID));

            new RewardNodeDataBuilder()
            {
                RewardNodeID = ID,
                MapNodePoolIDs = new List<string> 
                {
                    VanillaMapNodePoolIDs.RandomChosenMainClassUnit,
                    VanillaMapNodePoolIDs.RandomChosenSubClassUnit
                },
                Name = "Test Clan Banner",
                Description = "Offers units from the illustrious Test Clan",
                RequiredClass = CustomClassManager.GetClassDataByID(TestClan.ID),
                FrozenSpritePath = "assets/TestClanBanner_Frozen.png",
                EnabledSpritePath = "assets/TestClanBanner_Enabled.png",
                DisabledSpritePath = "assets/TestClanBanner_Disabled.png",
                DisabledVisitedSpritePath = "assets/TestClanBanner_Disabled_Visited.png",
                GlowSpritePath = "assets/TestClanBanner_Glow.png",
                MapIconPath = "assets/TestClanBanner_Enabled.png",
                MinimapIconPath = "assets/TestClanBanner_Minimap.png",
                SkipCheckInBattleMode = true,
                OverrideTooltipTitleBody = false,
                NodeSelectedSfxCue = "Node_Banner",
                RewardBuilders = new List<IRewardDataBuilder>
                {
                    new DraftRewardDataBuilder()
                    {
                        DraftRewardID = RewardID,
                        _RewardSpritePath = "assets/TestClanBanner_Enabled.png",
                        _RewardTitleKey = "Test Clan Banner",
                        _RewardDescriptionKey = "Choose a card!",
                        Costs = new int[] { 100 },
                        _IsServiceMerchantReward = false,
                        DraftPool = cardPool,
                        ClassType = (RunState.ClassType)7,
                        DraftOptionsCount = 2,
                        RarityFloorOverride = CollectableRarity.Uncommon
                    }
                }
            }.BuildAndRegister();
        }
    }
}
