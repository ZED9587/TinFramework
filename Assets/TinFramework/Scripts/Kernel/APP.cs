/****************************************************
文件：APP.cs
作者：ZED
日期：2019/10/22 10:31:28
功能：模块托管中心
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APP : MonoBehaviour
{
    private static UIModule _uiModule = null;
    public static UIModule UI {
        get {
            if (null == _uiModule)
            {
                _uiModule = new UIModule();
            }
            return _uiModule;
        }
        private set { _uiModule = value; }
    }

    private static ResModule _resModule = null;
    public static ResModule RES {
        get {
            if (null == _resModule)
            {
                _resModule = new ResModule();
            }
            return _resModule;
        }
        private set { _resModule = value; }
    }

    private static EventModule _eventModule = null;
    public static EventModule Event {
        get
        {
            if (null == _eventModule)
            {
                _eventModule = new EventModule();
            }
            return _eventModule;
        }
        private set { _eventModule = value; }
    }

    private static NetModule _netModule = null;
    public static NetModule NET {
        get {
            if (null == _netModule)
            {
                _netModule = new NetModule();
            }
            return _netModule;
        }
        private set { _netModule = value; }
    }

    private void OnDestroy()
    {
        APP.Event = null;
        APP.RES = null;
        APP.NET = null;
        APP.UI = null;
    }
}

