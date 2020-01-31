/****************************************************
文件：ResUtil.cs
作者：ZED
日期：2020/01/31 11:53:09
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
#if UNITY_EDITOR
using UnityEditor;
#endif

public static class ResUtil
{
    private readonly static string prefabPath = "Assets/LoadRes/Prefab/";

    public static GameObject LoadPrefab(string prefab_name)
    {
        GameObject tempGo = null;
        string prefab_full_path = prefabPath + prefab_name;
#if UNITY_EDITOR
        prefab_full_path += ".prefab";
        tempGo = AssetDatabase.LoadAssetAtPath<GameObject>(prefab_full_path);
#elif UNITY_ANDROID

#elif UNITY_IOS

#endif
        return tempGo;
    }

    public static IEnumerator AsyncLoadPrefab(string prefab_name, UnityAction<GameObject> callBack)
    {
        GameObject tempGo = null;
        string prefab_full_path = prefabPath + prefab_name;
        AssetBundleCreateRequest assetBundleCreateRequest = AssetBundle.LoadFromFileAsync(prefab_full_path);
        yield return assetBundleCreateRequest.isDone;
        if (null != assetBundleCreateRequest.assetBundle)
        {
            AssetBundleRequest assetBundleRequest = assetBundleCreateRequest.assetBundle.LoadAssetAsync<GameObject>(prefab_name);
            yield return assetBundleRequest.isDone;
            tempGo = assetBundleRequest.asset as GameObject;
        }
        if (null != callBack)
            callBack(tempGo);
    }
}

