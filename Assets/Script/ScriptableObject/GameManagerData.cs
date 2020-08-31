using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "GameManager", menuName = "OnlyOne/GameManager")]
public class GameManagerData : MyScriptableObject
{

    //所有的设施
    public List<Facility> facilityList;
    public List<ExtensionBuilding> ExtensionBuildingList;
    public List<Material> MaterialList;

    //资源目录与文件信息
    private string assetPath = "Assets/ScriptableObject/";
    private DirectoryInfo _directoryInfo;
    private FileInfo[] _allAssetFileName;
    
    private new void OnEnable()
    {
        base.OnEnable();
        GetAllAssetFile();
        UpdateAllList();
    }

    //获得全部的文件信息和文件名
    public void GetAllAssetFile()
    {
        _directoryInfo = new DirectoryInfo(assetPath);
        _allAssetFileName = _directoryInfo.GetFiles("*.asset");
    }

    public void UpdateAllList()
    {
        //清空所有列表
        facilityList.Clear();
        ExtensionBuildingList.Clear();
        MaterialList.Clear();
        
        //用资源名读取Asset,随后分配给各个list
        foreach (var a in _allAssetFileName)
        {
            var temp = AssetDatabase.LoadAssetAtPath<MyScriptableObject>("Assets/ScriptableObject/" + a.Name);
            if (temp != null)
            {
                switch (temp.type)
                {
                    case "Facility":
                        facilityList.Add((Facility)temp);
                        break;
                    case "ExtensionBuilding":
                        ExtensionBuildingList.Add((ExtensionBuilding)temp);
                        break;
                    case "Material":
                        MaterialList.Add((Material)temp);
                        break;
                }

            }
        }
    }
    


}