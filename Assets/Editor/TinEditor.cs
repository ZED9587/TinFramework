using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TinEditor : Editor
{
    [MenuItem("游戏设计工具/全局配置界面")]
    public static void Tin() {
        //open editorwindow
        EditorWindow editorWindow = EditorWindow.GetWindow<TinEditorWindow>();
        editorWindow.Show();
    }
}
