using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ExtensionBuilding", menuName = "My/ExtensionBuilding")]
public class ExtensionBuilding : MyScriptableObject
{
    public string tName;
    public string count;
    public int workingCount;//正在工作的数量
    public int needWorkersCount;//每个建筑需要多少人工作
    public int maxWorkersCount;//最多需要多少人工作
    public int workerCount;//有多少人在工作
    public Facility belong;
    public int level;
    [TextArea]
    public string info;

    private new void OnEnable()
    {
        base.OnEnable();
    }
}