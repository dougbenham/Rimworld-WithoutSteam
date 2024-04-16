﻿using HarmonyLib;
using Verse;

namespace WithoutSteam.Patches.Dialog_MessageBox_Patches {

    [HarmonyPatch]
    [HarmonyPatch(typeof(Window), "PostOpen")]
    public static class PostOpen_Patch {

        public static void Postfix(this Window __instance) {
            if (__instance is Dialog_MessageBox dialogBox) {
	            string steamText = "SteamClientMissing".Translate();
                if (dialogBox.text == steamText) {
                    dialogBox.Close();
                    Log.Message("WithoutSteam closed a 'SteamClientMissing' window");
                }
            }
        }
    }
}