using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Leveraction : MonoBehaviour
{
    public Toggle item1;
    public Toggle item2;
    public Toggle item3;
    public Toggle item4;


    public GameObject gitem1;
    public GameObject gitem2;
    public GameObject gitem3;
    public GameObject gitem4;



    public bool fusion1 = false;
    public bool fusion2 = false;
    public void Start()
    {
       

    }

    

    public void Update()
    {

        if(item1.isOn == true) 
        {
            gitem3.SetActive(false);
            gitem4.SetActive(false);
            item3.isOn = false;
            item4.isOn = false;
            
        }
        if (item2.isOn == true)
        {
            gitem3.SetActive(false);
            gitem4.SetActive(false);
            item3.isOn = false;
            item4.isOn = false;
        }
        if (item3.isOn == true)
        {
            gitem1.SetActive(false);
            gitem2.SetActive(false);
            item1.isOn = false;
            item2.isOn = false;
        }
        if (item4.isOn == true)
        {
            gitem1.SetActive(false);
            gitem2.SetActive(false);
            item1.isOn = false;
            item2.isOn = false;
        }



        if (item1.isOn == true && item2.isOn == true )
        {
            fusion1 = true;
            fusion2 = false;
            Debug.Log(fusion1);
        }

        if (item3.isOn == true && item4.isOn == true)
        {
            fusion2 = true;
            fusion1 = false;
        }
        

    }

}
