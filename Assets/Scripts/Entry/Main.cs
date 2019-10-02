using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinFramework.Kernel;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(UIModule.Ins.gameObject.ToString());
        //Debug.Log(DBModule.Ins.gameObject.ToString());
        //Debug.Log(ResModule.Ins.gameObject.ToString());
        //Debug.Log(EventModule.Ins.gameObject.ToString());
        Debug.Log(TimeModule.Ins.gameObject.ToString());
        Debug.Log(TimeModule.Ins.gameObject.ToString());
        Debug.Log(TimeModule.Ins.gameObject.ToString());
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
