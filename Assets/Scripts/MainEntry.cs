using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEntry : MonoBehaviour
{

    void Start()
    {
        RegisterModules();
        GameObject.Destroy(gameObject);
    }

    void RegisterModules() {
        ModuleAllocation.Ins.GetModule<ResModule>();
        ModuleAllocation.Ins.GetModule<UIModule>();
        DontDestroyOnLoad(ModuleAllocation.Ins.gameObject);
    }
}
