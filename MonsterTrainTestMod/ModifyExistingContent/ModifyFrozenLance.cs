using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Managers;
using Trainworks.Constants;
using HarmonyLib;

namespace MonsterTrainTestMod.ModifyExistingContent
{
    class ModifyFrozenLance
    {
        public static void Modify()
        {
            string frozenLanceID = VanillaCardIDs.FrozenLance;
            var frozenLanceData = CustomCardManager.GetCardDataByID(frozenLanceID);

            // Add piercing to Frozen Lance's trait list
            var piercingTrait = new CardTraitData();
            string piercingTraitName = VanillaCardTraitTypes.CardTraitIgnoreArmor.AssemblyQualifiedName;
            piercingTrait.Setup(piercingTraitName);
            frozenLanceData.GetTraits().Add(piercingTrait);

            // Set Frozen Lance's damage to 12
            var frozenLanceDamageEffect = frozenLanceData.GetEffects()[0];
            Traverse.Create(frozenLanceDamageEffect).Field("paramInt").SetValue(12);

            // Instantiate the Frostbite CardEffect
            var frostbiteEffect = new CardEffectData();

            // Set its effect type
            string addStatusEffectName = VanillaCardEffectTypes.CardEffectAddStatusEffect.AssemblyQualifiedName;
            Traverse.Create(frostbiteEffect).Field("effectStateName").SetValue(addStatusEffectName);

            // Set targeting mode to be the same one used by Flash Freeze: Last Targeted Characters
            Traverse.Create(frostbiteEffect).Field("targetMode").SetValue(TargetMode.LastTargetedCharacters);

            // This field can't be null, or the game crashes with a NullPointerException
            // All the other null fields are fine, though
            Traverse.Create(frostbiteEffect).Field("targetModeStatusEffectsFilter").SetValue(new string[0]);

            // Create the Frostbite status and add it to the effect's status array
            StatusEffectStackData frostbiteStatus = new StatusEffectStackData();
            frostbiteStatus.statusId = VanillaStatusEffectIDs.Frostbite;
            frostbiteStatus.count = 327;
            var paramStatusEffects = new StatusEffectStackData[] { frostbiteStatus };
            Traverse.Create(frostbiteEffect).Field("paramStatusEffects").SetValue(paramStatusEffects);

            // Add the Frostbite effect to Frozen Lance's card effect list
            frozenLanceData.GetEffects().Add(frostbiteEffect);
        }
    }
}
