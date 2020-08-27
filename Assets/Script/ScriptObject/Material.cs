using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Materal",menuName = "MyItem/Materal")]
public class Material : ScriptableObject
{
    public string MaterialName;
    public string MaterialCount;
    [TextArea]
    public string MaterialInfo;
}
