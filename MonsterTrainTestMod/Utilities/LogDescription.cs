using I2.Loc;
using Trainworks.Managers;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MonsterTrainTestMod.Utilities
{
    class LogDescription
    {
        public static void Log(string cardID)
        {
            var cardData = CustomCardManager.GetCardDataByID(cardID);
            if (cardData != null)
            {
                UnityEngine.Debug.Log(LocalizationManager.GetTranslation(cardData.GetOverrideDescriptionKey()));
                return;
            }
            var charData = CustomCharacterManager.GetCharacterDataByID(cardID);
            if (charData != null)
            {
                foreach (var trigger in charData.GetTriggers())
                {
                    UnityEngine.Debug.Log(LocalizationManager.GetTranslation(trigger.GetDescriptionKey()));
                }
            }
        }
    }
}
