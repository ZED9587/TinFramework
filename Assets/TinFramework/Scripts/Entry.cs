/****************************************************
文件：Entry.cs
作者：ADMIN
日期：2019/10/22 10:31:07
功能：框架入口类
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        APP.RES.LLL();
    }

    void OnDestroy()
    {
        APP.OnDispose();    
    }
}
