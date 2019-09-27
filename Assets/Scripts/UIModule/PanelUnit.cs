using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelUnit : IUI
{

    private Dictionary<string, PopUIUnit> dicPopUIs = null;
    
    public void Close()
    {
        OnClosePanel();
    }

    public void Open()
    {
        OnOpenPanel();
    }

    public void Refresh()
    {
        OnRefreshPanel();
    }

    protected void OpenPopUI(string popUIName) {
        if (!string.IsNullOrEmpty(popUIName))
        {

        }
    }

    protected void RefreshPopUI() {

    }

    protected void ClosePopUI() {

    }

    public virtual void OnOpenPanel() { }

    public virtual void OnClosePanel() { }

    public virtual void OnRefreshPanel() { }
}
