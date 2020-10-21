using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;
using Trainworks.Builders;
using Trainworks.Managers;
using Trainworks.Constants;
using Trainworks.Enums;
using MonsterTrainModding;

namespace MonsterTrainTestMod.Clans
{
    class TestClan
    {
        public static readonly string ID = TestPlugin.GUID + "_TestClan";

        public static void BuildAndRegister()
        {
            new ClassDataBuilder
            {
                ClassID = ID,
                Name = "Test Clan",
                Description = "Test Clan Description",
                SubclassDescription = "Test Clan Sub Description",
                CardStyle = ClassCardStyle.Stygian,
                IconAssetPaths = new List<string>
                {
                    "assets/testclan_large.png",
                    "assets/testclan_large.png",
                    "assets/testclan_large.png",
                    "assets/testclan_silhouette.png"
                },
                UiColor = new Color(0.43f, 0.15f, 0.81f, 1f),
                UiColorDark = new Color(0.12f, 0.42f, 0.39f, 1f),
            }.BuildAndRegister();
        }
    }
}
