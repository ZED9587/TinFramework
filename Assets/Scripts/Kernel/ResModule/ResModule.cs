/****************************************************
文件：ResModule.cs
作者：ZED
日期：2019/10/02 13:46:35
功能：资源管理模块
*****************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace TinFramework.Kernel
{
    public class ResModule : MonoSingletonT<ResModule>
    {

        ///// <summary>
        ///// 同步加载UNITY组件
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="path"></param>
        ///// <returns></returns>
        //public T LoadComp<T>(string path) where T : Component
        //{
        //    return Resources.Load<T>(path);
        //}

        ///// <summary>
        ///// 异步加载对象实例
        ///// </summary>
        ///// <param name="path">资源路径</param>
        ///// <returns>GameObject</returns>
        //public void LoadGOAsync(string path,Action<GameObject> onFinish)
        //{
        //    StartCoroutine(Async(path,onFinish));
        //}

        //private IEnumerator Async(string path, Action<GameObject> onFinish)
        //{
        //    ResourceRequest rq = Resources.LoadAsync<GameObject>(path);
        //    yield return rq.isDone;
        //    if (null != onFinish)
        //    {
        //        GameObject tempGO = rq.asset as GameObject;
        //        onFinish(tempGO);
        //    }
        //}

        //protected override void OnInitialized()
        //{
        //    base.OnInitialized();
        //}

        //protected override void OnReleaseModule()
        //{
        //    base.OnReleaseModule();
        //}

        #region 加载AssetBundle资源
        public GameObject LoadAB(string prefabName) {
            GameObject prefabGO = null;
            AssetBundle assetBundle = AssetBundle.LoadFromFile("Assets/ABResources/cube");
            if (null != assetBundle)
            {
                 prefabGO = assetBundle.LoadAsset<GameObject>(prefabName);
            }
            return prefabGO;
        }
        #endregion

        public GameObject LoadFromFile(string path) {
            return null;
        }
    }
}

