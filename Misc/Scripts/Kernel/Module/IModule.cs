using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework
{
    public interface IModule
    {
        Transform parent { get; }
        /// <summary>
        /// Module Init
        /// </summary>
        void InitModule();
        /// <summary>
        /// Module Release
        /// </summary>
        void ReleaseModule();
    }
}
