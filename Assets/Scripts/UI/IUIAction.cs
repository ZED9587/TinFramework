using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUIAction
{
    GameObject root { get; set; }
    void Init();
    void Refresh();
    void Close();
}
