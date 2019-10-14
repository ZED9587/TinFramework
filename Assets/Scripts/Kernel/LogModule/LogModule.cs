/****************************************************
文件：LogModule.cs
作者：ZED
日期：2019/10/08 14:29:02
功能：日志模块
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework.Kernel
{
    public sealed class LogModule : MonoSingletonT<LogModule>
    {
        public bool isActive = true;

        private GUIStyle gUIStyle = null;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            gUIStyle = new GUIStyle();
            gUIStyle.fontSize = 30;
            gUIStyle.fontStyle = FontStyle.Bold;
        }

        public void LogUI(string content)
        {
            if (!string.IsNullOrEmpty(content))
            {
                Show(content);
            }
        }

        private string guiContent = string.Empty;
        private void Show(string content)
        {
            if (isActive)
                guiContent = content;
        }

        private void OnGUI()
        {
            if (!string.IsNullOrEmpty(guiContent))
            {
                GUI.Label(new Rect(Screen.width / 2f - 100f, Screen.height / 2f - 50f, 200f, 100f), guiContent,gUIStyle);
            }
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                if (!string.IsNullOrEmpty(guiContent))
                    guiContent = string.Empty;
        }
    }
}

