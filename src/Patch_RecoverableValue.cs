using HarmonyLib;
using SunnySideUp;

namespace UnlimitedStamina
{
    [HarmonyPatch(typeof(RecoverableValue), "CanConsume")]
    public static class Patch_RecoverableValue_CanConsume
    {
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result)
        {
            __result = true;

            return false;
        }
    }
}
