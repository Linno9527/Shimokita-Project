using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProductionLine", menuName = "My/ProductionLine")]
public class ProductionLine : ExtensionBuilding
{
    public int workingCount;//正在工作的生产线数量
    public int needWorkersCount;//每个生产线需要多少人工作
    public int maxWorkersCount;//最多需要多少人工作
    public int workerCount;//有多少人在工作
    public Item product;//生产线的产物
    
    private new void OnEnable()
    {
        base.OnEnable();
        UpdateInfo();
    }

    //用来更新自身的信息
    private void UpdateInfo()
    {
        tName = name;
        if (count == 0)
        {
            return;
        }

        maxWorkersCount = needWorkersCount * count;
        
    }

}
