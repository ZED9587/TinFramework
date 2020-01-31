/****************************************************
文件：TimeModule.cs
作者：ZED
日期：2020/01/31 14:54:29
功能：延迟执行
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeModule
{
    private static readonly string module_name = "TimeModule";
    private static readonly bool isDontDestroy = true;

    private static void CreateTimeModule() {
        if (!GameObject.Find(module_name))
        {
            GameObject go = new GameObject(module_name);
        }
    }

    public static void DelayDo(float delayTime,UnityAction callback = null) {
        
    }

    public void Cancel() {

    }
}

