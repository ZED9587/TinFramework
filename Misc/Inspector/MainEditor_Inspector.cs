/****************************************************
文件：MainEditor_Inspector.cs
作者：ZED
日期：2019/10/08 14:53:50
功能：Main的Inspector重绘
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Main))]
public class MainEditor_Inspector : Editor
{
    Main main = null;

    private void OnEnable()
    {
        this.main = target as Main;
    }

    //TODO..当选择IsServer时，出现ServerURL编辑框和Port编辑框
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (main.isServer)
        {
            EditorGUILayout.BeginVertical();
            main.URL = EditorGUILayout.TextField("服务器网址", main.URL);
            main.PORT = EditorGUILayout.TextField("服务器端口", main.PORT);
            EditorGUILayout.EndVertical();
        }
    }
}

