using HarmonyLib;
using MelonLoader;
using System.Reflection.Emit;

namespace FullSync
{
    [HarmonyPatch]
    internal class FullSync : MelonMod
    {
        static MelonPreferences_Entry<bool> doPatch;

        public override void OnLateInitializeMelon()
        {
            var cat = MelonPreferences.CreateCategory("FullSync");
            doPatch = cat.CreateEntry("Apply Patch", true);
        }

        static void DoTimescale()
        {
            if (doPatch.Value)
                RM.time.SetTargetTimescale(0, true);
        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(Game), "LevelSetupRoutine", MethodType.Enumerator)]
        static IEnumerable<CodeInstruction> LevelSetupPatches(IEnumerable<CodeInstruction> instructions)
        {
            int hits = 0;
            var closeConsole = AccessTools.Method(typeof(GameConsole), "CloseConsole");
            foreach (var code in instructions)
            {
                yield return code;
                if (code.Calls(closeConsole) && ++hits == 4)
                    yield return new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(FullSync), "DoTimescale"));
            }
        }
    }
}
