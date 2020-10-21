using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UpdateProLineInfoAndDoSomething : MonoBehaviour
{
    public ProductionLine thisProLine;
    public Text proLineName;
    public Text need;
    public Text working;
    public Text worker;

    //note:
    //这玩意其实没什么用，unity会自动判断需不需要把东西放在第二行
    //但我还是留个纪念，因为挺蠢的
    //
    // [SerializeField] private int warpNum; //一定数量后换行
    //
    //     Debug.Log(i + " " + i % warpNum);
    //     Debug.Log(i == warpNum);
    //     if ((i != 0 && (i % warpNum) == 0) || i == warpNum-1)
    //     {
    //         need.text += "\n";
    //     }

    //草他妈的老子注释没写吗，这堆代码是个什么玩意
    void Start()
    {
        UpdateInfo();
    }

    private void UpdateInfo()
    {
        if (thisProLine == null)
        {
            return;
        }

        proLineName.text = thisProLine.tName;
        if (thisProLine.product != null && thisProLine.product.need.Count != 0) 
        {
            List<Item> items = thisProLine.product.need;
            List<int> 反正是只用一次的临时变量什么名字都无所谓吧 = thisProLine.product.needCount;
            int count = thisProLine.product.need.Count;
            need.text = "";
            for (int i = 0; i < count; i++)
            {
                need.text += items[i].tName + "x" + 反正是只用一次的临时变量什么名字都无所谓吧[i] + " ";
            }
        }
        else
        {
            need.text = "木大";
        }


        working.text = "正在生产\n" + thisProLine.workingCount + "/" + thisProLine.count;
        worker.text = "正在工作\n" + thisProLine.workerCount + "/" + thisProLine.maxWorkersCount;
    }

}