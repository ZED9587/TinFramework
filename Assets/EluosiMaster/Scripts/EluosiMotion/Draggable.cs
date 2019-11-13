/****************************************************
文件：Draggable.cs
作者：ZED
日期：2019/11/13 10:43:33
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    protected bool dragging;

    private Draggable current;

    private EluosiSlot currentSlotOver = null;

    private static List<RaycastResult> hits = new List<RaycastResult>();

    private RectTransform rectTrans = null;

    private void Start()
    {
        current = this;
        rectTrans = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        dragging = true;
        currentSlotOver = null;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (dragging)
        {
            rectTrans.anchoredPosition = eventData.position;
            EluosiSlot slot = GetSlotUnderMouse();
            if (null != currentSlotOver)
                currentSlotOver.SetDraggableExit();
            currentSlotOver = slot;
            if (null != currentSlotOver)
                currentSlotOver.SetDraggableEnter();
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragging = false;
        currentSlotOver = null;
    }

    private EluosiSlot GetSlotUnderMouse() {
        PointerEventData pointer = new PointerEventData(EventSystem.current);
        pointer.position = Input.mousePosition;
        EventSystem.current.RaycastAll(pointer,hits);
        foreach (var hit in hits)
        {
            EluosiSlot slot = hit.gameObject.GetComponent<EluosiSlot>();
            if (null != slot)
            {
                return slot;
            }
        }
        return null;
    }
}

