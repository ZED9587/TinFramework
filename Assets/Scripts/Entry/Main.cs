using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TinFramework.Kernel;

public class Main : MonoBehaviour
{
    public bool isLog = true;

    // Start is called before the first frame update
    void Start()
    {
        Initialized();
        //LogModule.Ins.LogUI("检测出现ERROR!!!");
    }

    private void Initialized() {
        LogModule.Ins.isActive = isLog;
    }
}
