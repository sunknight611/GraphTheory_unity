using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using UnityEngine.SceneManagement;
using FairyGUI;
public class panel : MonoBehaviour
{
    private GComponent mainUI;
    private GList list;
    // Start is called before the first frame update
    void Start()
    {
        mainUI = GetComponent<UIPanel>().ui;
        list = mainUI.GetChild("n0").asList;
        list.SetVirtualAndLoop();
        list.itemRenderer = RenderListItem;
        list.numItems = 3;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void RenderListItem(int index,GObject obj)
    {
        GButton button = obj.asButton;
        button.icon = UIPackage.GetItemURL("04-LoopList", "n" +(index+1) );

    }

    private void switchScene()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("1111");
    }
}
