using BepInEx;
using HarmonyLib;

namespace UnlimitedStamina
{
    [BepInPlugin("lwitw.mods.UnlimitedStamina", "Unlimited stamina", "1.0.0")]
    public class UnlimitedStacksMod : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony("lwitw.mods.UnlimitedStamina").PatchAll();
            this.Logger.LogInfo((object) "Stamina is unlimited");
        }
    }
}
