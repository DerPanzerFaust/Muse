using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_help : MonoBehaviour
{
 

    public GameObject smollui;
    public GameObject bigui;
    public GameObject Craftingsys;
    public GameObject MainMenuObj;

    public bool switchcraft = false;
    public bool switchingMenu = false;
    public bool MainMenu = false;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Should be switching Craftmenu");
            switchcraft = !switchcraft;
            if(switchcraft == true)
            {
                Craftingsys.SetActive(true);
            }

            if (switchcraft == false)
            {
                Craftingsys.SetActive(false);
            }


        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Main Menu GO");
            MainMenu = !MainMenu;
            if(MainMenu == true)
            {
                MainMenuObj.SetActive(true);
            }
            if(MainMenu == false)
            {
                MainMenuObj.SetActive(false);
            }
        
        
        }

            if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Should be switching Helpmenu");
            switchingMenu = !switchingMenu;
            if (switchingMenu == true)
            {
                Debug.Log("true");
                smollui.SetActive(true);
                bigui.SetActive(false);
            }
            if (switchingMenu == false)
            {
                Debug.Log("false");
                smollui.SetActive(false);
                bigui.SetActive(true);
            }
        }
            
     
    } 
}

