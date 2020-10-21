using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisFacilityTransit : MonoBehaviour
{
    public Facility thisFacility;
    public GameObject exBuildingPanel;
    public GameObject proLinePanel;
    public GameObject infoPanel;

    private void OnEnable()
    {
        //exBuildingPanel.GetComponent<ExBuildingInfoForPlanningPanel>().thisFacility = thisFacility;
        proLinePanel.GetComponent<ProLineInfoForPlanningPanel>().thisFacility = thisFacility;
        infoPanel.GetComponent<FacilityInfoForPlanningPanel>().thisFacility = thisFacility;
    }
}
