using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework
{
    public class SingletonT<T> where T : class , new()
    {
        private static T ins = null;

        private static readonly object sysLock = new object();

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
                            ins = new T();
                        }
                    }
                }
                return ins;
            }
        }
    }
}
