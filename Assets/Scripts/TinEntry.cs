using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TinEntry : MonoBehaviour
{
    IEnumerator Start()
    {
        Debug.Log("XXXXXXXXXX--->RUNNING");
        //load test
        var temp = LoadModule.Ins.Load<GameObject>(ResEnum.Character,"10001");
        Debug.Log($"xxxxxxxxxxxxxxxxxxxxxxxxxx{temp.name}");
        GameObject go = GameObject.Instantiate<GameObject>(temp);
        temp = null;
        yield return null;
    }
}
