using HarmonyLib;
using Verse;

namespace WithoutSteam
{
	[StaticConstructorOnStartup]
	public class Main : Mod
	{
		public Main(ModContentPack content) : base(content)
		{
			var harmony = new Harmony("doug.withoutsteam");
			harmony.PatchAll();
		}
	}
}