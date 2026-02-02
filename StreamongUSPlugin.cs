using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;

namespace StreamongUS
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInProcess("Among Us.exe")]
    public class StreamongUSPlugin : BasePlugin
    {
        public const string PluginGuid = "com.dhyancanplay.streamongus";
        public const string PluginName = "StreamongUS";
        public const string PluginVersion = "1.0.0";

        public Harmony Harmony { get; } = new Harmony(PluginGuid);

        public override void Load()
        {
            Log.LogInfo($"Plugin {PluginName} is loaded!");
            Harmony.PatchAll();
            Log.LogInfo("All patches applied successfully!");
        }
    }
}
