using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class GCPAutomateBuild
{
    public static void Build() {
        Debug.Log("Build Start");

        string assetBundleDirectory = "Assets/StreamingAssets";
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);

        string[] scenes = { "ssets/Scenes/SampleScene.unity" };

        BuildPipeline.BuildPlayer(testScene, "./build/test.exe", BuildTarget.StandaloneWindows, BuildOptions.Development);

        //File.Delete(assetBundleDirectory);

        Debug.Log("Build Complete");
        //[MenuItem("PLEASE/BUILD")]
    }
}
