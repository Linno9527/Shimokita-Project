using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UpdateFacilityPanel : MonoBehaviour
{
    public GameManagerData _gameManagerData;

    public GameObject facilityListContent;
    public GameObject facilityUiPrefab;
    public GameObject planningPanel;

    void Start()
    {
        _gameManagerData = GameObject.FindWithTag("MainCamera").GetComponent<GameManager>().gameManagerData;
        UpdateFacilityPanelList();
    }


    private void UpdateFacilityPanelList()
    {
        //清空内容
        for (int i = 0; i < facilityListContent.transform.childCount; i++)
        {
            Destroy(facilityListContent.transform.GetChild(i).gameObject);
        }

        //从全局数据读取设施信息
        foreach (var facility in _gameManagerData.facilityList)
        {
            GameObject temp = Instantiate(facilityUiPrefab); //实例化一个
            SomeInfo someInfo = temp.GetComponent<SomeInfo>(); //把component拿出来备用
            someInfo.thisFacility = facility; //赋值
            someInfo.planningPanel = planningPanel; //赋值
            someInfo.UpdateFacilityInfo(); //执行一遍方法，如果在这个脚本里用start会出问题
            temp.transform.SetParent(facilityListContent.transform); //设定父对象，这里有个报错，但并没有用
        }
    }
}