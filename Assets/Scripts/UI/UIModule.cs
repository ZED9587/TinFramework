using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIModule : SingletonT<UIModule>
{
    private IDictionary<string,PanelUnit> dicPanels = null;
    private Stack<PanelUnit> stackShownPanels = null;

    public override void Initialize()
    {
        base.Initialize();
        if (null == dicPanels)
            dicPanels = new Dictionary<string, PanelUnit>();
        if (null == stackShownPanels)
            stackShownPanels = new Stack<PanelUnit>();
    }

    public void OpenPanel<T>() where T : PanelUnit, new()
    {
        IUIAction uIAction = null;
        string panelName = typeof(T).Name;
        PanelUnit panelUnit = GetPanelInCache(panelName);
        if (null == panelUnit)
        {
            T t = new T();
            panelUnit = t as PanelUnit;
            GameObject panel = LoadModule.Ins.Load<GameObject>(ResEnum.UI, panelName);
            uIAction = t as IUIAction;
            uIAction.root = panel;
            uIAction.Init();
        }
        else
            uIAction = panelUnit as IUIAction;
        uIAction.Refresh();
        stackShownPanels.Push(panelUnit);
        PanelMoveIn(panelUnit);
    }

    private PanelUnit GetPanelInCache(string panelName) {
        PanelUnit panelUnit = null;
        if (null != dicPanels)
            dicPanels.TryGetValue(panelName,out panelUnit);
        return panelUnit;
    }

    public void ClosePanel()
    {
        PanelUnit panelUnit = stackShownPanels.Peek();
        if (null != panelUnit)
        {
            IUIAction uIAction = panelUnit as IUIAction;
            uIAction.Close();
            PanelMoveOut(uIAction);
            stackShownPanels.Pop();
        }
    }

    private void PanelMoveIn(IUIAction uIAction) {

    }

    private void PanelMoveOut(IUIAction uIAction) {

    }
}
