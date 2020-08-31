using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Tools : MonoBehaviour
{
    public void VeryFuckingSimpleSortToExtensionBuildingList(List<ExtensionBuilding> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            //i,i+1
            for (int j = 0; j < list.Count - 1 - i; j++)
            {
                //两两比较 i i+1
                if (list[j].level > list[j + 1].level)
                {
                    var temp = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }
}