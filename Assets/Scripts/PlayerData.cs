using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    // Dit is voor de combine ui dat de buttons daar komen
    public GameObject comite1;
    public GameObject comite2;
    public GameObject comite3;
    public GameObject comite4;



    public bool IronKey;

    //Dit is de combined tools storage
    public bool tool1 = false;
    public bool tool2 = false;

    //Painting dinge
    public bool item = false;
    public bool item2 = false;
    public bool item3 = false;
    public bool item4 = false;
    public bool item5 = false;
    public bool item6 = false;
    public bool item7 = false;
    public bool item8 = false;
    public bool item9 = false;
   
    

   

 
    // Update is called once per frame
    void Update()
    {
        if (item == true)
        {
            Debug.Log("item1 collected");
        }

        if (item2 == true)
        {
            Debug.Log("item2 collected");
        }
        if (item3 == true)
        {
            Debug.Log("item3 collected");
            comite1.SetActive(true);
        }
        if (item4 == true)
        {
            Debug.Log("item4 collected");
            
        }
        if (item5 == true)
        {
            Debug.Log("item5 collected");
        }
        if (item6 == true)
        {
            Debug.Log("item6 collected");
           // comite2.SetActive(true);

        }
        if (item7 == true)
        {
            Debug.Log("item7 collected");
        }
        if (item8 == true)
        {
            Debug.Log("item8 collected");
            comite2.SetActive(true);

        }
        if (item9 == true)
        {
            Debug.Log("item9 collected");
            //comite4.SetActive(true);

        }

    }
}
