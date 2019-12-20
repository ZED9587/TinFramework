/****************************************************
文件：ResModule.cs
作者：ZED
日期：2019/12/15 15:00:29
功能：资源管理器
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ResModule
{
    public static T Load<T>(string loadPath) where T : UnityEngine.Object {
        if (string.IsNullOrEmpty(loadPath))
            return null;
#if UNITY_EDITOR
        loadPath = System.IO.Path.Combine("Assets/Res/", loadPath);
        var template = AssetDatabase.LoadAssetAtPath<T>(loadPath);
#endif
        return template;
    }
}

