/****************************************************
文件：ResModule.cs
作者：ZED
日期：2019/10/22 10:33:20
功能：资源加载模块
*****************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResModule
{
    public GameObject LoadPrefab() {
        return null;
    }

    /// <summary>
    /// 阻塞式异步接口
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public GameObject LoadAysnc(string path) {
        ResourceRequest rq = Resources.LoadAsync<GameObject>(path);
        while (!rq.isDone)
        {

        }
        return rq.asset as GameObject;
    }

    public GameObject LoadAsync(string path, Action<GameObject> onFinished) {
        ResourceRequest rq = Resources.LoadAsync<GameObject>(path);
        return null;
    }
}

