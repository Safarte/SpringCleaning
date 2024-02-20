using System.Reflection;
using BepInEx;
using JetBrains.Annotations;
using SpaceWarp;
using SpaceWarp.API.Assets;
using SpaceWarp.API.Mods;
using SpaceWarp.API.UI.Appbar;
using SpringCleaning.UI;
using UitkForKsp2.API;
using UnityEngine;
using UnityEngine.UIElements;

namespace SpringCleaning;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency(SpaceWarpPlugin.ModGuid, SpaceWarpPlugin.ModVer)]
public class SpringCleaningPlugin : BaseSpaceWarpPlugin
{
    // Useful in case some other mod wants to use this mod a dependency
    [PublicAPI] public const string ModGuid = MyPluginInfo.PLUGIN_GUID;
    [PublicAPI] public const string ModName = MyPluginInfo.PLUGIN_NAME;
    [PublicAPI] public const string ModVer = MyPluginInfo.PLUGIN_VERSION;

    /// Singleton instance of the plugin class
    [PublicAPI]
    public static SpringCleaningPlugin Instance { get; set; }

    // AppBar button IDs
    internal const string ToolbarOabButtonID = "BTN-SpringCleaningOAB";

    /// <summary>
    /// Runs when the mod is first initialized.
    /// </summary>
    public override void OnInitialized()
    {
        base.OnInitialized();

        Instance = this;

        // // Load all the other assemblies used by this mod
        // LoadAssemblies();
        //
        // // Load the UI from the asset bundle
        // var springCleaningUiUxml = AssetManager.GetAsset<VisualTreeAsset>(
        //     $"{ModGuid}/SpringCleaning_ui/ui/SpringCleaningUI/SpringCleaningUI.uxml"
        // );
        //
        // // Create the window options object
        // var windowOptions = new WindowOptions { WindowId = "SpringCleaning_SpringCleaningUI" };
        //
        // // Create the window
        // var springCleaningUiWindow = Window.Create(windowOptions, springCleaningUiUxml);
        // // Add a controller for the UI to the window's game object
        // var springCleaningUiController = springCleaningUiWindow.gameObject.AddComponent<SpringCleaningUIController>();
        //
        // // Register OAB AppBar Button
        // Appbar.RegisterOABAppButton(
        //     ModName,
        //     ToolbarOabButtonID,
        //     AssetManager.GetAsset<Texture2D>($"{ModGuid}/images/icon.png"),
        //     isOpen => springCleaningUiController.IsWindowOpen = isOpen
        // );
    }

    /// <summary>
    /// Loads all the assemblies for the mod.
    /// </summary>
    private static void LoadAssemblies()
    {
        // Load the Unity project assembly
        var currentFolder = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory!.FullName;
        var unityAssembly = Assembly.LoadFrom(Path.Combine(currentFolder, "SpringCleaning.Unity.dll"));
        // Register any custom UI controls from the loaded assembly
        CustomControls.RegisterFromAssembly(unityAssembly);
    }
}