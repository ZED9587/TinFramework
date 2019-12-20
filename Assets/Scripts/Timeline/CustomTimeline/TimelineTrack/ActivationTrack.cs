/****************************************************
文件：ActivationTrack.cs
作者：ZED
日期：2019/12/15 16:50:28
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

[TrackClipType(typeof(ActivationAsset))]
[TrackBindingType(typeof(ActivationBehaviour))]
public class ActivationGameObjectTrack : TrackAsset
{

}

