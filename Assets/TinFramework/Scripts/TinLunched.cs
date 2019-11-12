/****************************************************
文件：TinLunched.cs
作者：ZED
日期：2019/11/12 17:10:14
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILunched {
    void Lunched();
}

public class TinLunched : MonoBehaviour , ILunched
{
    protected TinSetting tinSetting = null;

    public void Lunched()
    {
        tinSetting = LoadSetting();
    }

    private TinSetting LoadSetting() {
        TinSetting _tinSetting = new TinSetting();
        return _tinSetting;
    }

    private void Start()
    {
        Lunched();
        TinLOG.ColorLog("这是一切的开始。。。",Color.red);
    }
}

