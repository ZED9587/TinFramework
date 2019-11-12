/****************************************************
文件：EluosiMAP.cs
作者：ZED
日期：2019/11/12 17:48:09
功能：地图网格
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//将所有的坐标处理成左下角（0，0）起点的坐标。

public class EluosiMAP
{
    private MAPSetting mapSetting = null;

    public EluosiMAP(MAPSetting mapSetting) {
        this.mapSetting = mapSetting;
    }

    public void GenerateMAP(Transform tranMapRoot) {
        Vector2 centerWorldPOS = (Vector2)tranMapRoot.position;

    }
}

