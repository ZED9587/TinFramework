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
    [MenuItem("Assets/Tin自动生成组/生成ScriptableObject文件。")]
    public static void Generate()
    {
        Object so = Selection.activeObject;
        if (null != so)
        {
            string filePath = AssetDatabase.GetAssetPath(so);
            if (filePath.EndsWith(".cs"))
            {
                ScriptableObject soFile = ScriptableObject.CreateInstance(so.name);
                if (null != soFile)
                {
                    AssetDatabase.CreateAsset(soFile, filePath.Replace(".cs", ".asset"));
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
                }
            }
            else
            {
                Debug.LogError("The File Must Be A CS FILE.");
            }
        }
    }
}

