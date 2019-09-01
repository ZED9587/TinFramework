using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMonoModule
{
    /// <summary>
    /// 模块初始化
    /// </summary>
    void InitModule();
    /// <summary>
    /// 模块帧刷新
    /// </summary>
    void UpdateModule();
    /// <summary>
    /// 模块释放
    /// </summary>
    void ReleaseModle();
}
