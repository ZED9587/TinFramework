using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework
{
    public class ModuleUnit<T> : SingletonT<T> , IModule where T : class , new()
    {
        private int moduleID = 0;
        public int ModuleID => this.moduleID;

        private string moduleName = string.Empty;
        public string ModuleName => this.moduleName;

        public void InitModule()
        {
            this.OnInitModule();
        }

        public void ReleaseModule()
        {
            this.OnReleaseModule();
        }

        public void UpdateModule()
        {
            this.OnUpdateModule();
        }

        public virtual void OnInitModule() { }

        public virtual void OnUpdateModule() { }

        public virtual void OnReleaseModule() { }
    }
}
