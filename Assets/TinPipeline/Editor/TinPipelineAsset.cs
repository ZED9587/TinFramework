/****************************************************
文件：TinPipelineAsset.cs
作者：ZED
日期：2019/12/13 19:06:30
功能：RP资源
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

[CreateAssetMenu(menuName = "Rendering/TinPipelineAsset")]
public class TinPipelineAsset : RenderPipelineAsset
{
    protected override IRenderPipeline InternalCreatePipeline()
    {
        return new TinPipeline();
    }
}

