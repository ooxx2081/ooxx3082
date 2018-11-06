using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    private Text textTitle { get; set; }
    private Text textMessage { get; set; }

    private Button btnYes { get; set; }
    private Text textYes { get; set; }

    private Button btnNo { get; set; }
    private Text textNo { get; set; }

    private void Awake()
    {
        //scan 
        int childCount = this.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            GameObject go = this.transform.GetChild(i).gameObject;
            Debug.Log("Child Index = " + i + " Name = " + go.name);
            if (go.name.Equals("Title"))
            {
                textTitle = go.GetComponent<Text>();
            }
            if (go.name.Equals("Message"))
            {
                textMessage = go.GetComponent<Text>();
            }
            if (go.name.Equals("BtnYes"))
            {
                btnYes = go.GetComponent<Button>();
                textYes = go.GetComponentInChildren<Text>(); //最短模式      
            }
            if (go.name.Equals("BtnNo"))
            {
                btnNo = go.GetComponent<Button>();
                textNo = go.GetComponentInChildren<Text>(); //最短模式      
            }

        }

        //init
        if (textTitle != null)
        {
            textTitle.text = "I M Right!";
        }
        if (textMessage != null)
        {
            textMessage.text = @"這個是測試的文字\n換行測試<br\>換行測試2";
        }
        if (textYes != null)
        {
            textYes.text = "OK";
        }
        if (textNo != null)
        {
            textNo.text = "否";
        }


    }

    // Use this for initialization
    void Start()
    {

    }

}


// Update is called once per frame
void Update () {
		
	}
}
