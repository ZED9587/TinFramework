/****************************************************
文件：TinPipeline.cs
作者：ZED
日期：2019/12/13 19:12:44
功能：自定义渲染管线
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

public class TinPipeline : RenderPipeline
{
    private CommandBuffer commandBuffer;
    private ScriptableCullingParameters cullingParameters;
    private CullResults cullResults;
    private Material errorMaterial;

    public TinPipeline()
    {
        commandBuffer = new CommandBuffer();
        cullResults = new CullResults();
    }

    public override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
    {
        foreach (Camera camera in cameras)
            Render(renderContext, camera);
    }

    private void Render(ScriptableRenderContext renderContext, Camera camera)
    {
        commandBuffer.Clear();
        commandBuffer.name = camera.name;
        var flags = camera.clearFlags;
        commandBuffer.ClearRenderTarget(
            (flags & CameraClearFlags.Depth) != 0,
            (flags & CameraClearFlags.Color) != 0,
            camera.backgroundColor
            );

        if (!CullResults.GetCullingParameters(camera, out cullingParameters))
        {
            return;
        }

        CullResults.Cull(ref cullingParameters, renderContext, ref cullResults);

        renderContext.SetupCameraProperties(camera);
        renderContext.ExecuteCommandBuffer(commandBuffer);
        //不透明物体
        var drawSettings = new DrawRendererSettings(camera, new ShaderPassName("SRPDefaultUnlit"));
        var filterSetting = new FilterRenderersSettings(true)
        {
            renderQueueRange = RenderQueueRange.opaque
        };
        drawSettings.sorting.flags = SortFlags.CommonOpaque;
        renderContext.DrawRenderers(cullResults.visibleRenderers, ref drawSettings, filterSetting);
        //天空盒
        renderContext.DrawSkybox(camera);
        //透明物体
        drawSettings.sorting.flags = SortFlags.CommonTransparent;
        filterSetting.renderQueueRange = RenderQueueRange.transparent;
        renderContext.DrawRenderers(cullResults.visibleRenderers, ref drawSettings, filterSetting);
        //错误材质
        DrawErrorShaderObject(renderContext, camera);
        //提交
        renderContext.Submit();
    }

    private void DrawErrorShaderObject(ScriptableRenderContext renderContext, Camera camera)
    {
        if (null == errorMaterial)
        {
            Shader errorShader = Shader.Find("Hidden/InternalErrorShader");
            errorMaterial = new Material(errorShader)
            {
                hideFlags = HideFlags.HideAndDontSave
            };
        }
        var drawSetting = new DrawRendererSettings(camera, new ShaderPassName("ForwardBase"));
        drawSetting.SetOverrideMaterial(errorMaterial, 0);
        var errorFilter = new FilterRenderersSettings(true);
        renderContext.DrawRenderers(cullResults.visibleRenderers, ref drawSetting, errorFilter);
    }

    public override void Dispose()
    {
        base.Dispose();
    }
}

