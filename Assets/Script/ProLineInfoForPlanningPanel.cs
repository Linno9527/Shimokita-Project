using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProLineInfoForPlanningPanel : MonoBehaviour
{
    private GameManagerData _gameManagerData;
    private Tools _tools;

    public Facility thisFacility;

    public GameObject content;
    public GameObject proLineUiPrefab;

    private void Awake()
    {
        GameObject minaCamera = GameObject.FindWithTag("MainCamera");
        _gameManagerData = minaCamera.GetComponent<GameManager>().gameManagerData;
        _tools = minaCamera.GetComponent<Tools>();
    }

    private void OnEnable()
    {
        UpdateProLinePanel();
    }

    public void UpdateProLinePanel()
    {
        //清空content
        _tools.ClearContent(content);

        //循环设施的扩展建筑列表
        for (int i = 0; i < _gameManagerData.extensionBuildingList.Count; i++)
        {
            var tempProLine = _gameManagerData.extensionBuildingList[i];
            if (tempProLine.GetType() == typeof(ProductionLine) && tempProLine.belong == thisFacility)
            {
                //如果是扩展建筑是生产线的话就创建一个UI
                GameObject temp = Instantiate(proLineUiPrefab); //实例化一个
                temp.GetComponent<UpdateProLineInfoAndDoSomething>().thisProLine = (ProductionLine) tempProLine;
                temp.transform.SetParent(content.transform);
            }
        }
    }
}