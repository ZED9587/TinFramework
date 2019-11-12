/****************************************************
文件：TinSingleton.cs
作者：ADMIN
日期：2019/11/12 17:27:07
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInitialize {
    void OnInit();
}


public class TinSingleton<T> : IInitialize where T : class , new()
{
    private static T ins = null;
    private readonly static object lockSys = new object();

    public static T Ins {
        get {
            if (null == ins)
            {
                lock (lockSys)
                {
                    if (null == ins)
                    {
                        ins = new T();
                        ((IInitialize)ins).OnInit();
                    }
                }
            }
            return ins;
        }
    }

    public virtual void OnInit() {

    }
}

