/****************************************************
文件：MonoSingletonT.cs
作者：ZED
日期：2019/10/02 13:40:25
功能：基于MonoBehavior的泛型单例
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework.Kernel
{
    /// <summary>
    /// Singleton Pattern (MonoBehavior )
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MonoSingletonT<T> : MonoBehaviour, IModule where T : MonoBehaviour
    {
        readonly private string moduleParentName = "【Module】";

        static private T ins = null;
        static private object sysLock = new object();

        public static T Ins
        {
            get
            {
                if (null == ins)
                {
                    lock (sysLock)
                    {
                        if (null == ins)
                        {
                            string name = typeof(T).Name;
                            GameObject go = new GameObject(name);
                            ins = go.AddComponent<T>();
                            IModule imodule = (ins as IModule);
                            imodule.InitModule();
                            go.transform.SetParent(imodule.parent);
                        }
                    }
                }
                return ins;
            }
        }

        Transform IModule.parent {
            get {
                Transform moduleTranParent = null;
                GameObject moduleGoParent = GameObject.Find(moduleParentName);
                if (null != moduleGoParent)
                    moduleTranParent = moduleGoParent.transform;
                if (null == moduleTranParent)
                {
                    moduleTranParent = (new GameObject(moduleParentName).transform);
                    DontDestroyOnLoad(moduleTranParent.gameObject);
                }
                return moduleTranParent;
            }
        }

        void IModule.InitModule()
        {
            OnInitialized();
        }

        void IModule.ReleaseModule()
        {
            OnReleaseModule();
            ins = null;
        }

        void OnDestroy()
        {
            (gameObject.GetComponent<T>() as IModule).ReleaseModule();
        }

        #region Virtual Method
        protected virtual void OnInitialized() { }

        protected virtual void OnReleaseModule() { }
        #endregion
    }
}


