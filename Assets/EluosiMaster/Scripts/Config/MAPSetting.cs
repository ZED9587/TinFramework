/****************************************************
文件：MAPSetting.cs
作者：ADMIN
日期：2019/11/12 18:04:46
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAPSetting
{
    public float eluosiUnitHeight => 72;
    public float eluosiUnitWidth => 72;
    public int rowCount => 11;
    public int columCount => 8;

    public float totalWidth = 0;
    public float totalHeight = 0;

    public MAPSetting() {
        totalWidth = eluosiUnitWidth * columCount;
        totalHeight = eluosiUnitHeight * rowCount;
    }
}

