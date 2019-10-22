/****************************************************
文件：IUI.cs
作者：ZED
日期：2019/10/02 14:43:50
功能：UI界面行为接口
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework.UI
{
    public interface IUI
    {
        /// <summary>
        /// 开启UI界面
        /// </summary>
        void Open();
        /// <summary>
        /// 刷新UI界面
        /// </summary>
        void Refresh();
        /// <summary>
        /// 关闭UI界面
        /// </summary>
        void Close();
    }
}
