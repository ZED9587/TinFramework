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
        private readonly static string abResInPath = "Assets/Res/Prefabs/";

        [MenuItem("游戏设计工具/测试MENU")]
        public static void Tin()
        {

        }

        [MenuItem("游戏设计工具/Build/Build Android资源")]
        public static void GenerateAndroidABRes()
        {
            CheckABFold();
            //AssetDatabase.FindAssets("t:Prefab", null);
            //Object[] objs = AssetDatabase.LoadAllAssetsAtPath(abResInPath);
            //if (null != objs)
            //{
            //    List<AssetBundleBuild> listAsssetBuilds = new List<AssetBundleBuild>();
            //    foreach (var item in objs)
            //    {
            //        //bundle
            //        AssetBundleBuild assetBundleBuild = new AssetBundleBuild();
            //        assetBundleBuild.assetBundleName = item.name;
            //        listAsssetBuilds.Add(assetBundleBuild);
            //    }
            //    BuildPipeline.BuildAssetBundles(abResOutPath, listAsssetBuilds.ToArray(), BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.Android);
            //}
        }


        private static void CheckABFold()
        {
            string abResPath = Application.dataPath + "/ABResources";
            if (!Directory.Exists(abResPath))
                Directory.CreateDirectory(abResPath);
        }

        [MenuItem("游戏设计工具/Build/Build Ios资源")]
        public static void GenerateIosABRes()
        {
            CheckABFold();
            //BuildPipeline.BuildAssetBundles(abResOutPath, BuildAssetBundleOptions.None, BuildTarget.iOS);
        }
    }
}
