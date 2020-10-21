using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//这个脚本用来给设施的UI更新信息
public class SomeInfo : MonoBehaviour
{
    public Facility thisFacility; //这个设施

    public Text facilityNameText; //显示设施名字的对象
    public GameObject planningPanel; //传过来的，规划建筑的panel

    public void UpdateFacilityInfo()
    {
        facilityNameText.text = thisFacility.tName; //设施名字
    }


    //打开设施规划面板，把facility传递过去，这个方法只会被按钮调用
    public void DisplayPanningPanel()
    {
        planningPanel.GetComponent<ThisFacilityTransit>().thisFacility = thisFacility;
        planningPanel.SetActive(true);
    }
}