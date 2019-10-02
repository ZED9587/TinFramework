/****************************************************
文件：PanelUnit.cs
作者：ZED
日期：2019/10/02 14:43:50
功能：Panel界面基类
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework.UI
{
    public class PanelUnit : IUI
    {
        public virtual void OnOpenPanel() { }

        public virtual void OnClosePanel() { }

        public virtual void OnRefreshPanel() { }

        public void Open()
        {
            throw new System.NotImplementedException();
        }

        public void Refresh()
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }
    }
}


