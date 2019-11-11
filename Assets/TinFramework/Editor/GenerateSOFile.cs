/****************************************************
文件：GenerateSOFile.cs
作者：ZED
日期：2019/11/11 20:43:04
功能：生成ScriptableObject文件
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;

public class GenerateSOFile : Editor
{
    [MenuItem("Assets/Tin自动生成组/生成ScriptableObject文件。",priority = 0)]
    public static void Generate()
    {
        Object so = Selection.activeObject;
        if (null != so)
        {
            Debug.Log("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx--->" + so.name);
            string filePath = AssetDatabase.GetAssetPath(so);
            Debug.Log("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx--->" + filePath);
            if (filePath.EndsWith(".cs"))
            {
                ScriptableObject soFile = ScriptableObject.CreateInstance(so.name);
                if (null != soFile)
                {
                    AssetDatabase.SaveAssets();
                }
                AssetDatabase.Refresh();
                //if (typeof(ScriptableObject).IsAssignableFrom(so.GetType()))
                //{
                //    ScriptableObject soFile = ScriptableObject.CreateInstance(so.name);
                //    if (null != soFile)
                //    {
                //        AssetDatabase.SaveAssets();
                //    }
                //    AssetDatabase.Refresh();
                //}
                //else
                //{
                //    Debug.Log("HELLLLLLLLLLLLLLLLLLLL");
                //}
                //TextAsset asset = AssetDatabase.LoadAssetAtPath<TextAsset>(filePath);
                //if (null != asset)
                //{
                //    Assembly assembly = Assembly.Load(asset.bytes);
                //    var type =  assembly.GetType(so.name);

                //}
            }
        }
    }
}

