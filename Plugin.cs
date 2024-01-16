using BepInEx;

namespace LethalCompanyTemplate
{
    [BepInPlugin("org.choripandev.plugins.stuffthatisverylethal", "Stuff that is very Lethal", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {"org.choripandev.plugins.stuffthatisverylethal"} is loaded!");
        }
    }
}