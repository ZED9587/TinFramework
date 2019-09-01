using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleAllocation : MonoBehaviour
{
    public List<string> listModuleNames = null;
    private Dictionary<string, IMonoModule> dicModules = null;

    private static ModuleAllocation ins = null;
    public static ModuleAllocation Ins {
        get
        {
            if (null == ins)
            {
                GameObject go = new GameObject("ModuleAllocation");
                ins =  go.AddComponent<ModuleAllocation>();
                ins.Init();
            }
            return ins;
        }
    }

    public void Init()
    {
        if (null == dicModules)
            dicModules = new Dictionary<string, IMonoModule>();
        dicModules.Clear();
        if (null == listModuleNames)
            listModuleNames = new List<string>();
        listModuleNames.Clear();
    }

    public void GetModule<T>() where T : IMonoModule , new() {
        string moduleName = typeof(T).Name;
        IMonoModule iMomoModule = null;
        if (!string.IsNullOrEmpty(moduleName))
        {
            dicModules.TryGetValue(moduleName,out iMomoModule);
        }
        if (null == iMomoModule)
        {
            iMomoModule = new T() as IMonoModule;
            iMomoModule.InitModule();
            listModuleNames.Add(moduleName);
            dicModules.Add(moduleName,iMomoModule);
        }
    }

    private void ReleaseMoudles() {
        foreach (KeyValuePair<string,IMonoModule> keyValuePair in dicModules)
        {
            keyValuePair.Value.ReleaseModle();
        }
    }

    private void UpdateModules() {
        foreach (KeyValuePair<string, IMonoModule> keyValuePair in dicModules)
        {
            keyValuePair.Value.UpdateModule();
        }
    }

    private void Update()
    {
        UpdateModules();
    }

    private void OnDestroy()
    {
        ReleaseMoudles();
    }
}
