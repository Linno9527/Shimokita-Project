using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

using Object = UnityEngine.Object;

public class Tools : MonoBehaviour
{
    /// <summary>
    /// 用来清除viewport下的content的所有内容
    /// </summary>
    public void ClearContent(GameObject content)
    {
        if (content.transform.childCount == 0)
        {
            return;
        }
        
        for (int i = 0; i < content.transform.childCount; i++)
        {
            Destroy(content.transform.GetChild(i).gameObject);
        }
    }
    
    
    public class ChangeFontWindow : EditorWindow
    {
        [MenuItem("自制工具/批量更换字体")]
        public static void Open()
        {
            EditorWindow.GetWindow(typeof(ChangeFontWindow));
        }
 
        public Font toChange;
        static Font toChangeFont;
 
        void OnGUI()
        {
            GUILayout.Label("选择要换的字体，然后去左边的列表选择父对象\n即可批量替换字体");
            toChange = (Font)EditorGUILayout.ObjectField(toChange, typeof(Font), true, GUILayout.MinWidth(20f));
            toChangeFont = toChange;
            titleContent = new GUIContent("批量更换字体");
            if (GUILayout.Button("批量更换字体"))
            {
                Change();
            }
        }
 
        public static void Change()
        {
            Object[] labels = Selection.GetFiltered(typeof(Text), SelectionMode.Deep);
            foreach (Object item in labels)
            {
                Text text = (Text)item;
                text.font = toChangeFont;
                Debug.Log(item.name + ":" + text.text);
            }
        }
    }
}