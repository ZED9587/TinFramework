using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

namespace TinFramework
{
    public class TinEditor : Editor
    {
        private readonly static string abResOutPath = "Assets/ABResources";

        [MenuItem("游戏设计工具/测试MENU")]
        public static void Tin()
        {

        }

        [MenuItem("游戏设计工具/Build/Build Android资源")]
        public static void GenerateAndroidABRes()
        {
            CheckABFold();
            AssetBundleManifest assetBundleManifest = BuildPipeline.BuildAssetBundles(abResOutPath, BuildAssetBundleOptions.None, BuildTarget.Android);
        }


        private static void CheckABFold() {
            string abResPath = Application.dataPath + "/ABResources";
            if (!Directory.Exists(abResPath))
            {
                Directory.CreateDirectory(abResPath);
            }
        }

        [MenuItem("游戏设计工具/Build/Build Ios资源")]
        public static void GenerateIosABRes()
        {
            CheckABFold();
            //BuildPipeline.BuildAssetBundles(abResOutPath, BuildAssetBundleOptions.None, BuildTarget.iOS);
        }
    }
}
