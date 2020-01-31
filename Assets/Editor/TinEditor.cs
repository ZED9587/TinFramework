/****************************************************
文件：TinEditor.cs
作者：ZED
日期：2020/01/31 11:40:06
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class TinEditor : Editor
{
    [MenuItem("游戏设计工具/【运行游戏】")]
    public static void TinRunning() {
        string scene_path = "Assets/Scenes/MainEntry.unity";
        EditorSceneManager.OpenScene(scene_path,OpenSceneMode.Single);
        EditorApplication.isPlaying = true;
        Debug.Log("TinFrame---><color=green>游戏运行！</color>");
    }
}

