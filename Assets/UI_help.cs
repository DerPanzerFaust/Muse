using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_help : MonoBehaviour
{
 

    public GameObject smollui;
    public GameObject bigui;
    public bool a = true;
    public bool alwdtomv;
    public int speed = 6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Should be switching");
            a = !a;
            if (a == true)
            {
                Debug.Log("true");
                smollui.SetActive(true);
                bigui.SetActive(false);
            }
            if (a == false)
            {
                Debug.Log("false");
                smollui.SetActive(false);
                bigui.SetActive(true);
            }
        }
            
     
    } 

    void movement()
    {

    }


}

