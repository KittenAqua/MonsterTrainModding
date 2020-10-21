using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace MonsterTrainTestMod.SamplePatches
{
    //[HarmonyPatch(typeof(CardPoolHelper), "GetCardsForClass")]
    //[HarmonyPatch(new Type[] { typeof(CardPool), typeof(ClassData), typeof(CollectableRarity), typeof(CardPoolHelper.RarityCondition), typeof(bool) })]
    //class NoCardRestrictionsPatch
    //{
    //    static void Postfix(ref List<CardData> __result, ref CardPool cardPool)
    //    {
    //        List<CardData> list = new List<CardData>();
    //        for (int i = 0; i < cardPool.GetNumCards(); i++)
    //        {
    //            CardData cardAtIndex = cardPool.GetCardAtIndex(i);
    //            list.Add(cardAtIndex);
    //        }
    //        __result = list;
    //    }
    //}
}
