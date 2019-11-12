/****************************************************
文件：EluosiUnit.cs
作者：ADMIN
日期：2019/11/12 17:59:25
功能：Noting
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct EluosiUnitPOS
{
    public Vector2 vec2POS;
    public Vector3 vec3POS
    {
        get
        {
            return new Vector3(vec2POS.x, vec2POS.y, 0);
        }
    }
}

public class EluosiUnit
{

}

