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
    class AddCardToStartingDeckPatch
    {
        static void Postfix(ref SaveManager __instance)
        {
            __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(NotHornBreak.ID));
            __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(GiveEveryoneArmor.ID));
            __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(PlayOtherCards.ID));
            __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(BlueEyesWhiteDragon.ID));
            __instance.AddCardToDeck(CustomCardManager.GetCardDataByID(DragonCostume.ID));
        }
    }
}
