using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

//这里是物品，未来会有很多代码
[CreateAssetMenu(fileName = "Item", menuName = "My/Item")]
public class Item : MyScriptableObject
{
    public string tName; //名字
    public string count; //物品的数量
    public List<Item> need; //制作这个物品需要的物品
    public List<int> needCount; //对应的数量
    [TextArea] public string info;

    private new void OnEnable()
    {
        tName = name;
    }

}