using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TinFramework;
using UnityEngine.EventSystems;

public class UIModule : ModuleUnit<UIModule>
{

    public void OpenPanel() {

    }

    public void ClosePanel() {

    }

    public void RefreshPanel() {

    }

    public override void OnInitModule()
    {
        base.OnInitModule();
        GenerateUIEx();
    }

    public override void OnUpdateModule()
    {
        base.OnUpdateModule();
    }

    public override void OnReleaseModule()
    {
        base.OnReleaseModule();
    }


    //********************************************************** 
    //UIEx
    // |---UICamera
    // |---EventSystem
    // |---Canvas
    //     |--subCanvas (name = 1)(Layer = UI)(order = 5)
    //     |--subCanvas (name = 2)(Layer = UI)(order = 10)
    //     |--subCanvas (name = 3)(Layer = UI)(order = 15)
    //     |--subCanvas (name = 4)(Layer = UI)(order = 20)
    //     |--subCanvas (name = 5)(Layer = UI)(order = 25)
    //     |--death（name = death）(Layer = deathUI)(order = 0)
    //************************************************************
    /// <summary>
    /// 生成UIEx
    /// </summary>
    private void GenerateUIEx() {
        //Root
        GameObject uiExObj = new GameObject("UIEx");
        //Camera
        GameObject cameraObj = new GameObject("UICamera");
        cameraObj.transform.SetParent(uiExObj.transform);
        Camera camera = cameraObj.AddComponent<Camera>();
        camera.clearFlags = CameraClearFlags.SolidColor;
        camera.cullingMask = LayerMask.NameToLayer("UI");
        camera.orthographic = true;
        camera.orthographicSize = 5;
        camera.nearClipPlane = 1f;
        camera.farClipPlane = 500f;
        //EventSystem
        GameObject eventSystemObj = new GameObject("EventSystem");
        eventSystemObj.transform.SetParent(uiExObj.transform);
        eventSystemObj.AddComponent<EventSystem>();
        eventSystemObj.AddComponent<StandaloneInputModule>();
        //Layers
        GameObject canvas = new GameObject("Canvas");
        canvas.layer = LayerMask.NameToLayer("UI");
        CanvasScaler scaler = canvas.AddComponent<CanvasScaler>(); //Require Canvas
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1334f,750f);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        Canvas canvasComp = canvas.GetComponent<Canvas>();
        canvasComp.renderMode = RenderMode.ScreenSpaceCamera;
        canvasComp.worldCamera = camera;
        canvas.AddComponent<GraphicRaycaster>();
        canvas.transform.SetParent(uiExObj.transform);
        for (int i = 0; i < 5; i++)
        {
            GameObject layer = new GameObject((i + 1).ToString());
            layer.layer = LayerMask.NameToLayer("UI");
            Canvas layerCanvas = layer.AddComponent<Canvas>();
            layer.transform.SetParent(canvas.transform);
            layerCanvas.overrideSorting = true;
            layerCanvas.sortingOrder = (i + 1) * 5;
        }
        GameObject deathLayer = new GameObject("deathUI");
        deathLayer.layer = LayerMask.NameToLayer("DeathUI");
        deathLayer.transform.SetParent(canvas.transform);
        Canvas deathCanvas = deathLayer.AddComponent<Canvas>();
        deathCanvas.overrideSorting = true;
        deathCanvas.sortingOrder = 0;
    }
}
