using BepInEx;
using Jotunn.Entities;
using Jotunn.Managers;
using Jotunn.Utils;
using System.IO;
using UnityEngine;

namespace FoxthorneTestMod
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    //[NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.Minor)]
    internal class FoxthorneTestMod : BaseUnityPlugin
    {
        public const string PluginGUID = "com.werefawkes.foxthornetestmod";
        public const string PluginName = "FoxthorneTestMod";
        public const string PluginVersion = "0.0.1";
        
        // Use this class to add your own localization to the game
        // https://valheim-modding.github.io/Jotunn/tutorials/localization.html
        public static CustomLocalization Localization = LocalizationManager.Instance.GetLocalization();

        private void Awake()
        {
            // Jotunn comes with its own Logger class to provide a consistent Log style for all mods using it
            Jotunn.Logger.LogInfo("ModStub has landed");
            
            // To learn more about Jotunn's features, go to
            // https://valheim-modding.github.io/Jotunn/tutorials/overview.html
        }

        private void LoadAssets()
		{
            string modPath = Path.GetDirectoryName(Info.Location);

            //Jotunn.Logger.LogInfo($"Embedded resources: {string.Join(", ", typeof(JotunnModExample).Assembly.GetManifestResourceNames())}");

            // Load asset bundles from embedded resources
            AssetBundle EmbeddedResourceBundle = AssetUtils.LoadAssetBundleFromResources("steel");
            GameObject BackpackPrefab = EmbeddedResourceBundle.LoadAsset<GameObject>("Iron1");
        }
    }
}