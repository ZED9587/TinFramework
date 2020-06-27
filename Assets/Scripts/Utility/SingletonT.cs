using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonT<T> : IInit where T : class, new()
{
    private static T ins = null;
    private static readonly object syslock = new object();

    public static T Ins
    {
        get
        {
            if (null == ins)
            {
                lock (syslock)
                {
                    if (null == ins)
                    {
                        ins = new T();
                        IInit iinit = ins as IInit;
                        iinit.Initialize();
                    }
                }
            }

            return ins;
        }
    }

    public virtual void Initialize()
    {
    }

    ~SingletonT()
    {
        ins = null;
    }
}