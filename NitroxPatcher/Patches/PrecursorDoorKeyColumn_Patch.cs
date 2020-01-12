﻿using System;
using System.Reflection;
using Harmony;
using NitroxClient.GameLogic;
using NitroxModel.Core;

namespace NitroxPatcher.Patches
{
    class PrecursorDoorKeyColumn_Patch : NitroxPatch
    {
        public static readonly Type TARGET_CLASS = typeof(PrecursorDoorKeyColumn);
        public static readonly MethodInfo TARGET_METHOD = TARGET_CLASS.GetMethod("SlotKey", BindingFlags.Public | BindingFlags.Instance);

        public static void Postfix(PrecursorDoorKeyColumn __instance)
        {
            NitroxServiceLocator.LocateService<Precursor>().OnKeyColunm(__instance);
        }

        public override void Patch(HarmonyInstance harmony)
        {
            PatchPostfix(harmony, TARGET_METHOD);
        }
    }
}
