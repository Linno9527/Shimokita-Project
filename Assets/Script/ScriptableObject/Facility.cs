using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Facility", menuName = "My/Facility")]
public class Facility : MyScriptableObject
{
    private GameManagerData _gameManagerData;

    public string tName; //设施的名称，为了避免和自带的name搞混
    public int level; //设施的等级，可以提升的

    [TextArea] //设施的信息 
    public string info;

    //扩展建筑列表
    public List<ExtensionBuilding> extensionBuildingList;

    public new void OnEnable()
    {
        base.OnEnable();
        //从摄像机把数据的object拉过来
        _gameManagerData = GameObject.Find("Main Camera").GetComponent<GameManager>().gameManagerData;
        //刷新扩展建筑列表
        UpdateExBuildingList();
    }

    private void UpdateExBuildingList()
    {
        //先清空
        extensionBuildingList.Clear();

        //然后把所有属于这个设施的扩展建筑塞进来
        foreach (var exb in _gameManagerData.ExtensionBuildingList)
        {
            if (exb.belong == this)
            {
                extensionBuildingList.Add(exb);
            }
        }
    }
}