using System;
using System.Collections.Generic;
using System.Text;
using Trainworks.Managers;
using Steamworks;

namespace MonsterTrainTestMod.Utilities
{
    class LogAllCards
    {
        public static void Log()
        {
            StringBuilder stringBuilder = new StringBuilder();
            var regex = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");
            foreach (CardData data in ProviderManager.SaveManager.GetAllGameData().GetAllCardData())
            {
                stringBuilder.Append("/// <summary>\n");
                stringBuilder.Append("/// Asset name: " + data.GetAssetKey());
                stringBuilder.Append("\n/// </summary>\n");
                stringBuilder.Append("public static readonly string ");
                var name = data.GetNameEnglish();
                name = regex.Replace(name, "");
                stringBuilder.Append(name);
                stringBuilder.Append(" = \"");
                stringBuilder.Append(data.GetID());
                stringBuilder.Append("\";\n");
            }
            UnityEngine.Debug.Log(stringBuilder.ToString());
        }
    }
}
