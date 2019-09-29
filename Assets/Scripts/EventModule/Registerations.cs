using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IRegisterations
{

}

public class Registerations<T> : IRegisterations
{
    public Action<T> OnReceives = obj => { };
}
