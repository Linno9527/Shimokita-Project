using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelUpInfo",menuName = "My/LevelUpInfo")]
public class FacilityLevelUpInfo : ScriptableObject
{
    public Facility levelUpFacilityName;
    public int upToLevel;
    public List<Item> needMaterial;
    public List<int> needMaterialCount;
}
