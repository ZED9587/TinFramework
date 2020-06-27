using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelUnit : IUIAction
{
    public GameObject root { get; set; }

    public virtual void OnInit()
    {

    }

    public virtual void OnRefresh()
    {

    }

    public virtual void OnClose()
    {

    }

    public void Init()
    {
        OnInit();
    }

    public void Refresh()
    {
        OnRefresh();
    }

    public void Close()
    {
        OnClose();
    }
}
