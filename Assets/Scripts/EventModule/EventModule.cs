/****************************************************
文件：EventModule.cs
作者：ZED
日期：2019/10/02 14:04:43
功能：事件管理模块
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TinFramework.Kernel
{
    public class EventModule : MonoSingletonT<EventModule>
    {
        private Dictionary<Type, IRegisterations> dicEventType;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            if (null == dicEventType)
                dicEventType = new Dictionary<Type, IRegisterations>();
        }

        public void Register<T>(Action<T> onReceive)
        {
            var type = typeof(T);
            IRegisterations registerations = null;
            if (dicEventType.TryGetValue(type, out registerations))
            {
                var reg = registerations as Registerations<T>;
                reg.OnReceives += onReceive;
            }
            else
            {
                var reg = new Registerations<T>();
                reg.OnReceives += onReceive;
                dicEventType.Add(type, reg);
            }
        }

        public void UnRegister<T>(Action<T> onReceive)
        {
            var type = typeof(T);
            IRegisterations registerations = null;
            if (dicEventType.TryGetValue(type, out registerations))
            {
                var reg = registerations as Registerations<T>;
                reg.OnReceives -= onReceive;
            }
        }

        public void Send<T>() where T : class, new()
        {
            T t = new T();
            var type = t.GetType();
            IRegisterations registerations = null;
            if (dicEventType.TryGetValue(type, out registerations))
            {
                var reg = registerations as Registerations<T>;
                reg.OnReceives(t);
            }
        }
    }
}

