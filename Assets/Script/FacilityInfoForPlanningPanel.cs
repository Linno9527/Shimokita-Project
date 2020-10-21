using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

//这玩意给建筑规划面板显示信息，估计之后会有很多代码，但现在先闲着
public class FacilityInfoForPlanningPanel : MonoBehaviour
{
    public Facility thisFacility;

    public Text nameText;
    public Text infoText;
    public Text levelText;
    public Text exText;
    public Text levelUpNeedText;

    private void OnEnable()
    {
        UpdateInfoPanel();
    }

    private void UpdateInfoPanel()
    {
        if (thisFacility != null)
        {
            nameText.text = thisFacility.tName;
            infoText.text = thisFacility.info;
            levelText.text = thisFacility.level.ToString();

            foreach (var exb in thisFacility.extensionBuildingList)
            {
                exText.text += "\n" + exb.tName;
            }

            //这个if很他妈长，首先非空检测，然后非零，然后看有没有升到下一级的信息，infolist的count会比等级少1，所以要减去
            if (thisFacility.levelUpInfo != null && thisFacility.levelUpInfo.Count != 0 && thisFacility.levelUpInfo.Count < thisFacility.level - 1)
            {
                FacilityLevelUpInfo info = thisFacility.levelUpInfo[thisFacility.level];
                levelUpNeedText.text = "";
                for (int i = 0; i < info.needMaterial.Count; i++)
                {
                    levelUpNeedText.text += info.needMaterial[i].tName + "/" + info.needMaterialCount[i] + " ";
                    if (i != 0 && i % 5 == 4) //每5个换行
                    {
                        levelUpNeedText.text += "\n";
                    }
                }
            }
            else
            {
                levelUpNeedText.text = "没有从 " + thisFacility.level + " 级升级到 " + (thisFacility.level + 1) + " 级的信息，我还没做";
            }
        }
    }

    private void UpdatePlanPanel()
    {
        //不想写了
    }
}