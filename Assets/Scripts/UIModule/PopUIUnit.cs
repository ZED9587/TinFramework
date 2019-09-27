using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PopUIUnit : IUI
{
    public abstract GameObject PopUIRoot { get; set; }

    public void Close()
    {
        OnClosePopUI();
    }

    public void Open()
    {
        OnOpenPopUI();
    }

    public void Refresh()
    {
        OnRefreshPopUI();
    }

    public virtual void OnOpenPopUI() {

    }

    public virtual void OnRefreshPopUI() {

    }

    public virtual void OnClosePopUI() {

    }
}
