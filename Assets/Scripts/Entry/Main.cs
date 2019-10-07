using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinFramework.Kernel;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject  go = ResModule.Ins.LoadAB("Capsule");
        //if (go)
        //{
        //    GameObject tempGO = GameObject.Instantiate<GameObject>(go);
        //}
    }

    #region Event Example
    public class EventA {
        public string strEvent = "执行事件A。";
    }

    private void TestEventModule() {
        //EventModule.Ins.Register<EventA>(OnRecieveEventA);
        //EventModule.Ins.Send<EventA>();
    }

    private void OnRecieveEventA(EventA a) {
        Debug.Log("事件模块测试--->" + a.strEvent);
    }
    #endregion
}
