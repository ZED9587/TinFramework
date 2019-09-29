using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinFramework;
using System;

public class EventModule : ModuleUnit<EventModule>
{
    private Dictionary<Type, IRegisterations> dicEventType = new Dictionary<Type, IRegisterations>();

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

    public void UnRegister<T>(Action<T> onReceive) {
        var type = typeof(T);
        IRegisterations registerations = null;
        if (dicEventType.TryGetValue(type,out registerations))
        {
            var reg = registerations as Registerations<T>;
            reg.OnReceives -= onReceive;
        }
    }

    public void Send<T>(T t) {
        var type = typeof(T);
        IRegisterations registerations = null;
        if (dicEventType.TryGetValue(type,out registerations))
        {
            var reg = registerations as Registerations<T>;
            reg.OnReceives(t);
        }
    }

    public override void OnInitModule()
    {
        base.OnInitModule();
    }

    public override void OnUpdateModule()
    {
        base.OnUpdateModule();
    }

    public override void OnReleaseModule()
    {
        base.OnReleaseModule();
    }
}
