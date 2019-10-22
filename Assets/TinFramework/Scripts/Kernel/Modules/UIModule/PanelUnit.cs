/****************************************************
文件：PanelUnit.cs
作者：ZED
日期：2019/10/22 23:32:30
功能：UI窗口界面基类
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelUnit : MonoBehaviour
{
    public int panelID => 0;

    public string panelName => string.Empty;

    private List<PanelUnit> listSubPanels = null;

    public void Open() {
        if (null == listSubPanels)
        {
            listSubPanels = new List<PanelUnit>();
        }
        OnOpen();
    }

    public void Refresh() {
        OnRefresh();
    }

    public void Close() {
        if (null != listSubPanels)
        {
            foreach (var panel in listSubPanels)
            {
                panel.Close();
            }
        }
        OnClose();
    }

    protected virtual void OnOpen() { }

    protected virtual void OnRefresh() { }

    protected virtual void OnClose() { }

    public void OpenSubPanel(string panelName)
    {

    }
}

