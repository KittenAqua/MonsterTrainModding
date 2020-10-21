using MonsterTrainModding;
using Trainworks.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterTrainTestMod.MonsterCards
{
    class SubtypeDragon
    {
        public static readonly string Key = TestPlugin.GUID + "_Subtype_Dragon";

        public static void BuildAndRegister()
        {
            CustomCharacterManager.RegisterSubtype(Key, "Dragon");
        }
    }
}
