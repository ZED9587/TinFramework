using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public class LoadModule : SingletonT<LoadModule>
{
    private readonly string rootPath = "Assets/ABRes/";
    public override void Initialize()
    {
        base.Initialize();
        Debug.Log("资源加载模块初始化成功。");
    }

    public T Load<T>(ResEnum resEnum,string targetName) where T : Object
    {
        T temp = null;
#if UNITY_EDITOR
        //TODO...考虑资源的管理。例如:引用计数,自动卸载
        string full_path = Path.Combine(rootPath,resEnum.ToString(),targetName+GetExtName(typeof(T)));
        Debug.Log(full_path);
        temp = AssetDatabase.LoadAssetAtPath<T>(full_path);
#else
#endif
        return temp;
    }

    private string GetExtName(Type type)
    {
        string _ExtName = "";
        if (type == typeof(GameObject))
            _ExtName = ".prefab";
        return _ExtName;
    }

    private string GetFullPath()
    {
        return "";
    }
}