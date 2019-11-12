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
    private float eluosiUnitHeight => 0;
    private float eluosiUnitWidth => 0;
    private int rowCount => 0;
    private int columCount => 0;

    public float totalWidth = 0;
    public float totalHeight = 0;

    public MAPSetting() {
        totalWidth = eluosiUnitWidth * columCount;
        totalHeight = eluosiUnitHeight * rowCount;
    }
}

