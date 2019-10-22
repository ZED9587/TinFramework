using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinFramework.Kernel;

public class Main : MonoBehaviour
{
    public bool isLog = true;

    public bool isServer = false;
    [HideInInspector]
    public string URL = string.Empty;
    [HideInInspector]
    public string PORT = string.Empty;

    // Start is called before the first frame update
    void Start()
    {
        Initialized();
        //LogModule.Ins.LogUI("检测出现ERROR!!!");
        GameObject go = ResModule.Ins.LoadAB("cube");
        Debug.Log(go.name);
    }

    private void Initialized() {
        LogModule.Ins.isActive = isLog;
    }
}
