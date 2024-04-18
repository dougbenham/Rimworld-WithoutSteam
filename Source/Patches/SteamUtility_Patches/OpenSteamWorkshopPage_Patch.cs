﻿using HarmonyLib;
using UnityEngine;
using Verse;
using WithoutSteam.Utils;

namespace WithoutSteam.Patches.SteamUtility_Patches
{
	[HarmonyPatch]
	[HarmonyPatch(typeof(SteamUtility), "OpenSteamWorkshopPage")]
	public static class OpenSteamWorkshopPage_Patch
	{
		public static bool Prefix()
		{
			Application.OpenURL(SteamUtils.RimWorldSteamWorkshopUrl);
			return false;
		}
	}
}