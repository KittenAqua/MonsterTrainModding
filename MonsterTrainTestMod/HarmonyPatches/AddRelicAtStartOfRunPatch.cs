using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using MonsterTrainModding;
using Trainworks.Managers;
using MonsterTrainTestMod.SpellCards;
using MonsterTrainTestMod.MonsterCards;
using MonsterTrainTestMod.SamplePatches;

namespace MonsterTrainTestMod.HarmonyPatches
{
    [HarmonyPatch(typeof(SaveManager), "SetupRun")]
    class AddRelicAtStartOfRunPatch
    {
        static void Postfix(ref SaveManager __instance)
        {
            __instance.AddRelic(CustomCollectableRelicManager.GetRelicDataByID(Wimpcicle.ID));
        }
    }
}
