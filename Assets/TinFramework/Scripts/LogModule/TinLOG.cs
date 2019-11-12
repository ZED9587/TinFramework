/****************************************************
文件：TinLOG.cs
作者：ADMIN
日期：2019/11/12 17:26:35
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//支持组颜色打印

public class TinLOG
{
    public static void ColorLog(string strs,Color color) {
        string hexNumber = ColorUtility.ToHtmlStringRGB(color);
        string outContent = string.Format("<color=#{0}>{1}</color>", hexNumber, strs);
        Debug.Log(outContent);
    }
}

