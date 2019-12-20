/****************************************************
文件：ActivationAsset.cs
作者：ZED
日期：2019/12/15 16:51:04
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ActivationAsset : PlayableAsset
{
    public GameObject target;

    public bool isActive = true;

    public override double duration => 0.2d;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<ActivationBehaviour>.Create(graph);
        var activationBehaviour = playable.GetBehaviour();
        activationBehaviour.target = target;
        activationBehaviour.isActive = isActive;
        return playable;
    }
}

