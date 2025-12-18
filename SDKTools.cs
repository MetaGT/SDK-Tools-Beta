using System.Collections.Generic;
using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Reflection;
using GorillaNetworking;

public static class SDKTools
{
    [MenuItem("SDKToolsV.1/Main/RippingTools/AddAllLaunchPads (SOON)")]
    private static void AddAllLaunchPads()
    {
        Application.OpenURL("https://frogiesarcade.win");
    }

    [MenuItem("SDKToolsV.1/Main/Tutorials/CSharpLesson")]
    private static void CSharpLessons()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=GhQdlIFylQ8");
    }

    [MenuItem("SDKToolsV.1/Main/Navigation/UrGameFiles")]
    private static void UrGameFiles()
    {
        Application.OpenURL("");
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/RestoreJumpscares")]
    private static void RestoreJumpscares()
    {
        Type metatype = Type.GetType("EnemyController");
        UnityEngine.Object[] runners = UnityEngine.Object.FindObjectsOfType(metatype);
        foreach (UnityEngine.Object metamonster in runners)
        {
            GameObject biz = ((Component)metamonster).gameObject;
            AddIfMissing(biz, "BetterQuitOnCollision");
            AddIfMissing(biz, "Jumpscare2");
        }
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/FixAllLights")]
    private static void FixAllLights()
    {
        Light[] lights = UnityEngine.Object.FindObjectsOfType<Light>();

        foreach (Light bip in lights)
        {
            bip.intensity = 6f;
        }
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/FixEnabledLights")]
    private static void FixEnabledLights()
    {
        Light[] lights = UnityEngine.Object.FindObjectsOfType<Light>();
        foreach (Light bip in lights)
        {
            if (bip.enabled)
            {
                bip.intensity = 6f;
            }
        }
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/SetAll2Static")]
    private static void SetAll2Static()
    {
        GameObject[] skids = UnityEngine.Component.FindObjectsOfType<GameObject>();
        foreach (GameObject meta in skids)
        {
            GameObjectUtility.SetStaticEditorFlags(meta, 0);
        }
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/GorillaComputerRecover")]
    private static void GorillaComputerRecover()
    {
        UpdateMOTD[] motdObjects = UnityEngine.Object.FindObjectsOfType<UpdateMOTD>();
        foreach (UpdateMOTD motd in motdObjects)
        {
            GameObject go = motd.gameObject;

            if (!go.TryGetComponent<GorillaComputer>(out _))
            {
                go.AddComponent<GorillaComputer>();
            }
        }
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/Packages2Install")]
    private static void Packages2Install()
    {
        Gibber.ShowWindow();
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/FixServers")]
    private static void FixServers()
    {
        Application.OpenURL("https://tinyurl.com/49tmnfct");
    }

    [MenuItem("SDKToolsV.1/Main/GameTools/UncombineShit")]
    private static void UncombineShit()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

        foreach (GameObject obj in allObjects)
        {
            MeshCollider meshCollider = obj.GetComponent<MeshCollider>();
            MeshFilter meshFilter = obj.GetComponent<MeshFilter>();

            if (meshCollider != null && meshFilter != null && meshCollider.sharedMesh != null)
            {
                meshFilter.sharedMesh = meshCollider.sharedMesh;
            }
            else if (meshFilter != null && meshCollider == null)
            {
                GameObjectUtility.SetStaticEditorFlags(obj, 0);
            }
        }
    }

    [MenuItem("SDKToolsV.1/Main/Fixes/FixLag/READ ME")]
    private static void OpenFixLag()
    {
        SDKToolsFixLagWindow.ShowWindow();
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/RestoreAllTexts")]
    private static void RestoreAllTexts()
    {
        CanvasRenderer[] renderers = UnityEngine.Object.FindObjectsOfType<CanvasRenderer>();

        foreach (CanvasRenderer cr in renderers)
        {
            if (cr.GetComponent<Text>() == null)
            {
                Text text = cr.gameObject.AddComponent<Text>();
                text.text = cr.gameObject.name;
                text.color = Color.black;
                text.font = Resources.GetBuiltinResource<Font>("Roboto-Regular.ttf");
                text.alignment = TextAnchor.MiddleCenter;
            }
        }
    }

    [MenuItem("SDKToolsV.1/Main/RippingTools/RestoreMobsterScripts")]
    private static void RestoreMobsterScripts()
    {
        Type monsterType = Type.GetType("MonsterResetOnDisable");

        if (monsterType == null)
        {
            return;
        }

        UnityEngine.Object[] mobsters = UnityEngine.Object.FindObjectsOfType(monsterType);

        foreach (UnityEngine.Object mobster in mobsters)
        {
            GameObject go = ((Component)mobster).gameObject;

            AddIfMissing(go, "EnemyController");
            AddIfMissing(go, "PhotonView");
            AddIfMissing(go, "PhotonRigidbodyView");
            AddIfMissing(go, "PhotonAnimatorView");
            AddIfMissing(go, "BetterQuitOnCollision");

            if (go.GetComponent<Animator>() == null)
                go.AddComponent<Animator>();
        }
    }

    private static void AddIfMissing(GameObject go, string typeName)
    {
        Type t = Type.GetType(typeName);
        if (t == null) return;

        if (go.GetComponent(t) == null)
            go.AddComponent(t);
    }

    [MenuItem("SDKToolsV.1/Credits")]
    private static void Credits()
    {
        Application.OpenURL("https://pastebin.com/raw/wZL1trXg");
    }

    [MenuItem("SDKToolsV.1/DiscordServer")]
    private static void DiscordServer()
    {
        Application.OpenURL("https://discord.gg/VUcYWVT5gw");
    }

    [MenuItem("SDKToolsV.1/Main/Fixes/FixLag/ClickMeAfterUHaveAddedDaScript")]
    private static void ClickMeAfterUHaveAddedDaScript()
    {
        Type cghlover = Type.GetType("GeoGerome");
        if (cghlover == null)
        {
            return;
        }
        UnityEngine.Object[] kanye = UnityEngine.Object.FindObjectsOfType(cghlover);
        foreach (UnityEngine.Object mib in kanye)
        {
            GameObject gg = ((Component)mib).gameObject;
            AddIfMissing(gg, "LODGroup");
        }
    }
}

public class SDKToolsFixLagWindow : EditorWindow
{
    public static void ShowWindow()
    {
        GetWindow<SDKToolsFixLagWindow>("meta says");
    }

    private void OnGUI()
    {
        GUILayout.Label("add a script no components added onto the game", EditorStyles.boldLabel);
        GUILayout.Label("object that you want to have a anti lag on", EditorStyles.boldLabel);
        GUILayout.Label("and name the script GeoGerome then drag it onto", EditorStyles.boldLabel);
        GUILayout.Label("the GameObject", EditorStyles.boldLabel);
    }
}

public class Gibber : EditorWindow
{
    public static void ShowWindow()
    {
        GetWindow<Gibber>("meta says");
    }

    private void OnGUI()
    {
        GUILayout.Label("Full Screen This Tab First: Animation Rigging, Burst, Cinemachine, Input System, TextMeshPro, Test Framework, Timeline, XR Interaction Manager, XR Interaction Toolkit", EditorStyles.boldLabel);
    }
}

