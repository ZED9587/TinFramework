/****************************************************
文件：EluosiSlot.cs
作者：ADMIN
日期：2019/11/13 10:28:50
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EluosiSlot : MonoBehaviour
{
    public Image img;

    public void SetDraggableEnter() {
        img.color = Color.red;
    }

    public void SetDraggableExit() {
        img.color = Color.white;
    }
}

