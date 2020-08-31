using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//所有自定的scriptableobject的父类，有一个type，用来判断类型，因为读asset的时候比较迷惑
public class MyScriptableObject : ScriptableObject
{
    public string type;

    public void OnEnable()
    {
        type = GetType().ToString();
    }
}
