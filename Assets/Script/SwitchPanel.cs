using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel : MonoBehaviour
{
    public GameObject allInfoPanel;
    public GameObject buildingPanel;
    public GameObject makePanel;
    public GameObject warehousePanel;
    public GameObject explorePanel;

    private void AllSetActiveFalse()
    {
        allInfoPanel.SetActive(false);
        buildingPanel.SetActive(false);
        makePanel.SetActive(false);
        warehousePanel.SetActive(false);
        explorePanel.SetActive(false);
    }

    public void AllInfoPanelSetActiveTrue()
    {
        AllSetActiveFalse();
        allInfoPanel.SetActive(true);
    }

    public void BuildingPanelSetActiveTrue()
    {
        AllSetActiveFalse();
        buildingPanel.SetActive(true);
    }

    public void MakePanelSetActiveTrue()
    {
        AllSetActiveFalse();
        makePanel.SetActive(true);
    }

    public void WarehousePanelSetActiveTrue()
    {
        AllSetActiveFalse();
        warehousePanel.SetActive(true);
    }

    public void ExplorePanelSetActiveTrue()
    {
        AllSetActiveFalse();
        explorePanel.SetActive(true);
    }
}