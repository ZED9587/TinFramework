/****************************************************
文件：MainEntry.cs
作者：ZED
日期：2020/01/31 14:51:21
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEntry : MonoBehaviour
{
    void Start()
    {
        GameObject go = ResUtil.LoadPrefab("TestCube");
        GameObject.Instantiate<GameObject>(go);
    }
}

