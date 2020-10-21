using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionBuilding : MyScriptableObject
{
    public string tName;
    public int count;
    public Facility belong;
    public int level;
    public bool isBuild;
    [TextArea]
    public string info;

    private new void OnEnable()
    {
        base.OnEnable();
    }
}