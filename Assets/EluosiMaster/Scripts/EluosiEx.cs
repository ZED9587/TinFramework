/****************************************************
文件：EluosiEx.cs
作者：ZED
日期：2019/11/12 20:24:20
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EluosiEx : MonoBehaviour
{
    public RectTransform tranMAPRoot = null;
    public RectTransform tranMAPUnit = null;

    public RectTransform moveMAP = null;

    private EluosiMAP eluosiMAP = null;

    // Start is called before the first frame update
    void Start()
    {
        eluosiMAP = new EluosiMAP(new MAPSetting());
        eluosiMAP.GenerateMAP(tranMAPRoot, tranMAPUnit);
    }
}

