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
    private RectTransform tranMapRoot = null;

    private MAPSetting mapSetting = null;

    public EluosiMAP(MAPSetting mapSetting)
    {
        this.mapSetting = mapSetting;
    }

    public void GenerateMAP(RectTransform tranMapRoot, RectTransform tranMapUnit)
    {
        this.tranMapRoot = tranMapRoot;
        this.tranMapRoot.sizeDelta = new Vector2(mapSetting.totalWidth, mapSetting.totalHeight);
        for (int i = 0, size = mapSetting.rowCount * mapSetting.columCount; i < size; i++)
        {
            GameObject goMapUnit = GameObject.Instantiate<GameObject>(tranMapUnit.gameObject);
            if (goMapUnit)
            {
                RectTransform rect = goMapUnit.GetComponent<RectTransform>();
                float x = (i % mapSetting.columCount) * mapSetting.eluosiUnitWidth;
                float y = Mathf.CeilToInt(i / mapSetting.columCount) * mapSetting.eluosiUnitHeight;
                rect.SetParent(tranMapRoot);
                rect.localScale = Vector3.one;
                rect.localRotation = Quaternion.identity;
                rect.anchoredPosition = new Vector3(x, y, 0);
            }
        }
    }
}

