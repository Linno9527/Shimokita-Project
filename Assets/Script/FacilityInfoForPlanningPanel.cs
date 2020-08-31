using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//这玩意给建筑规划面板显示信息，估计之后会有很多代码，但现在先闲着
public class FacilityInfoForPlanningPanel : MonoBehaviour
{
    public Facility thisFacility;

    public Text haText;

    private void OnEnable()
    {
        haText.text = thisFacility.info;
    }
}