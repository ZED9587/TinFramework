using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestEventModule();
    }

    #region Event Example
    public class EventA {
        public string strEvent = "测试。";
    }

    private void TestEventModule() {
        EventModule.Ins.Register<EventA>(OnRecieveEventA);
        EventModule.Ins.Send<EventA>(new EventA());
    }

    private void OnRecieveEventA(EventA a) {
        Debug.Log("事件模块测试完毕。" + a.strEvent);
    }
    #endregion
}
