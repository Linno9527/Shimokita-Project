using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//这里是物品，未来会有很多代码
[CreateAssetMenu(fileName = "Materal",menuName = "My/Materal")]
public class Material : MyScriptableObject
{
    public string tName;
    public string count;
    [TextArea]
    public string info;
}
