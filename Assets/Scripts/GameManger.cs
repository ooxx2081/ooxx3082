using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject UIRoot = null;
    public GameObject PoolRoot = null;
    public GameObject DispRoot = null;

    private List<GameObject> ModelList = new List<GameObject>();
    private int CurrentPosition = 0; //目前model的位置

    void Start()
    {
        //scan UI
        if (UIRoot != null)
        {
            int childCount = UIRoot.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject child = UIRoot.transform.GetChild(i).gameObject;
                if (child.name.Equals("BtnLeft"))
                {
                    Button button = child.GetComponent<Button>();
                    button.onClick.AddListener(BtnLeftOnClick);
                }
            }
        }


        //scan pool root ,put model into list
        if (PoolRoot != null)
        {
            int childCount = PoolRoot.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                ModelList.Add(PoolRoot.transform.GetChild(i).gameObject);
            }
        }

    }

    public void BtnLeftOnClick()
    {
        Debug.Log("BtnLeftOnClick");
    }
    public void BtnRightOnClick()
    {

    }


    // Update is called once per frame
    void Update()
    {

    }
}
