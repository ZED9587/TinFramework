/****************************************************
文件：ActivationBehaviour.cs
作者：ZED
日期：2019/12/15 16:50:46
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ActivationBehaviour : PlayableBehaviour
{
    public GameObject target;

    public bool isActive = true;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        base.ProcessFrame(playable, info, playerData);
        if (null != target)
            target.SetActive(isActive);
    }
}

