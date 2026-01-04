#nullable enable
using UnityEditor;
using UnityEngine;

public static class DependencyCheckerDebug
{
    [MenuItem("Tools/NOPPERS/DependencyChecker/Debug/Enable")]
    public static void ToggleDebug()
    {
        NoppersDependencyChecker.SetDebugMode(!NoppersDependencyChecker.IsDebugEnabled());
        Debug.Log($"Dependency Checker Debug Logging: {(NoppersDependencyChecker.IsDebugEnabled() ? "Enabled" : "Disabled")}");
    }

    [MenuItem("Tools/NOPPERS/DependencyChecker/Debug/Enable", true)]
    public static bool ToggleDebugValidate()
    {
        Menu.SetChecked("Tools/NOPPERS/DependencyChecker/Debug", NoppersDependencyChecker.IsDebugEnabled());
        return true;
    }

    [MenuItem("Tools/NOPPERS/DependencyChecker/Debug/VPM Resolve All")]
    public static void TriggerVPMResolve()
    {
        DependencyIssuesWindow.OpenPackageResolverAndResolve();
    }

    [MenuItem("Tools/NOPPERS/DependencyChecker/Debug/VPM Resolve All", true)]
    public static bool TriggerVPMResolveValidate()
    {
        return NoppersDependencyChecker.IsDebugEnabled();
    }

    [MenuItem("Tools/NOPPERS/DependencyChecker/Debug/List All Open Windows")]
    public static void ListOpenWindows()
    {
        var windows = Resources.FindObjectsOfTypeAll<EditorWindow>();
        Debug.Log($"=== Found {windows.Length} open windows ===");
        foreach (var window in windows)
        {
            Debug.Log($"Title: '{window.titleContent.text}' | Type: {window.GetType().FullName}");
        }
    }

    [MenuItem("Tools/NOPPERS/DependencyChecker/Debug/List All Open Windows", true)]
    public static bool ListOpenWindowsValidate()
    {
        return NoppersDependencyChecker.IsDebugEnabled();
    }
}
