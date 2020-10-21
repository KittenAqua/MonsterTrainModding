using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace MonsterTrainTestMod.SamplePatches
{
    // Credit to Rawsome, Stable Infery for this one.
    // Fun fact: This was the first modded code ever run in Monster Train. :)
    [HarmonyPatch(typeof(TooltipGenerator), nameof(TooltipGenerator.GetRelicTooltips))]
    class TooltipGenerator_GetRelicTooltips_Patch
    {
        static void Postfix(ref List<TooltipContent> tooltips)
        {
            tooltips.Add(new TooltipContent("Testi", "Moddy mod tooltip", TooltipDesigner.TooltipDesignType.Default));
        }
    }
}
