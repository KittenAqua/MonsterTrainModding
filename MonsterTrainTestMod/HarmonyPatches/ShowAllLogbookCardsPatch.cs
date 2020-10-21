using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace MonsterTrainTestMod.SamplePatches
{
    [HarmonyPatch(typeof(MetagameSaveData), "HasDiscoveredCard", new Type[] { typeof(CardData) })]
    class ShowAllLogbookCardsPatch
    {
        static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }

    [HarmonyPatch(typeof(MetagameSaveData), "HasDiscoveredCard", new Type[] { typeof(string) })]
    class ShowAllLogbookCardsPatch2
    {
        static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}
