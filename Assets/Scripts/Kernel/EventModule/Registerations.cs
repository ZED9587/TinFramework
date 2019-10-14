/****************************************************
文件：Registerations.cs
作者：ZED
日期：2019/10/02 14:08:50
功能：事件源接口
*****************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace TinFramework.Kernel
{
    public interface IRegisterations
    {

    }

    public class Registerations<T> : IRegisterations
    {
        public Action<T> OnReceives = obj => { };
    }
}


