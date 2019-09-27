using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework
{
    public class ModuleSchedule : MonoBehaviour
    {
        private Dictionary<int, IModule> dicModules = null;

        private void Start()
        {
            RegisterModules();
            Init();
        }

        private void Init()
        {
            foreach (var item in dicModules)
                item.Value.InitModule();
        }

        private void Update()
        {
            foreach (var item in dicModules)
                item.Value.UpdateModule();
        }

        private void OnDestroy()
        {
            foreach (var item in dicModules)
                item.Value.ReleaseModule();
        }

        private void RegisterModules() {
            if (null == dicModules)
                dicModules = new Dictionary<int, IModule>();
            dicModules.Clear();
            dicModules.Add(10001,UIModule.Ins);
            dicModules.Add(10002, ResModule.Ins);
        }
    }
}
