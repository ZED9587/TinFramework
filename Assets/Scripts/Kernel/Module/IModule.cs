using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinFramework
{
    public interface IModule
    {
        /// <summary>
        /// Module Init
        /// </summary>
        void InitModule();
        /// <summary>
        /// Module Update
        /// </summary>
        void UpdateModule();
        /// <summary>
        /// Module Release
        /// </summary>
        void ReleaseModule();
    }
}
