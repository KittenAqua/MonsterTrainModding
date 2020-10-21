using BepInEx;
using HarmonyLib;
using System.Collections.Generic;
using Trainworks.Managers;
using MonsterTrainTestMod.Utilities;
using MonsterTrainTestMod.ModifyExistingContent;
using System.Text;
using MonsterTrainTestMod.SpellCards;
using MonsterTrainTestMod.SamplePatches;
using UnityEngine;
using StateMechanic;
using Trainworks.AssetConstructors;
using Trainworks.Builders;
using System.Runtime.CompilerServices;
using UnityEngine.AddressableAssets;
using System.Text.RegularExpressions;
using Trainworks.Interfaces;
using Trainworks.Constants;
using MonsterTrainTestMod.MonsterCards;
using MonsterTrainTestMod.Clans;

namespace MonsterTrainModding
{

    // Credit to Rawsome, Stable Infery for the base of this method.
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInProcess("MonsterTrain.exe")]
    [BepInProcess("MtLinkHandler.exe")]
    [BepInDependency("tools.modding.trainworks")]
    public class TestPlugin : BaseUnityPlugin, IInitializable
    {
        public const string GUID = "com.name.package.generic";
        public const string NAME = "Test Plugin";
        public const string VERSION = "0.1.0";

        private void Awake()
        {
            var harmony = new Harmony(GUID);
            harmony.PatchAll();
        }

        public void Initialize()
        {
            TestClan.BuildAndRegister();
            TestClanChampion.BuildAndRegister();
            ModifyFrozenLance.Modify();
            NotHornBreak.BuildAndRegister();
            GiveEveryoneArmor.BuildAndRegister();
            PlayOtherCards.BuildAndRegister();
            SubtypeDragon.BuildAndRegister();
            BlueEyesWhiteDragon.BuildAndRegister();
            DragonCostume.BuildAndRegister();
            AppleMorsel.BuildAndRegister();
            Wimpcicle.BuildAndRegister();
            TestClanBanner.BuildAndRegister();
        }
    }
}
