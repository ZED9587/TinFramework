/****************************************************
文件：TinEditor.cs
作者：ADMIN
日期：2019/11/11 21:23:09
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TinEditor : Editor
{
    [MenuItem("游戏开发工具/检查空文件夹。")]
    public static void Generate()
    {
        Debug.Log("检查空文件夹！！！");
    }
}

