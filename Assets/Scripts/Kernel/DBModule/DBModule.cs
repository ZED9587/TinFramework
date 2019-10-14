/****************************************************
文件：DBModule.cs
作者：ZED
日期：2019/10/02 14:15:10
功能：数据持久化管理模块
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework.Kernel
{
    public class DBModule : MonoSingletonT<DBModule>
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        public void Save(string key,int value) {
            PlayerPrefs.SetInt(key,value);
        }

        public void Save(string key, string value)
        {
            PlayerPrefs.SetString(key,value);
        }

        public void Save(string key,float value) {
            PlayerPrefs.SetFloat(key,value);
        }

        public int GetInt(string key) {
            return PlayerPrefs.GetInt(key);
        }

        public float GetFloat(string key) {
            return PlayerPrefs.GetFloat(key);
        }

        public string GetString(string key) {
            return PlayerPrefs.GetString(key);
        }

        /// <summary>
        /// 清除所有的持久化数据
        /// </summary>
        public void ClearAll() {
            ClearAllPlayerPrefs();
            ClearAllSqlContent();
        }

        private void ClearAllPlayerPrefs() {
            PlayerPrefs.DeleteAll();
        }

        /// <summary>
        /// 清除所有的Sql数据
        /// </summary>
        private void ClearAllSqlContent() {

        }
    }
}

