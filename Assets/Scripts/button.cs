using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject buttons;
    public Leveraction lever;
    public PlayerData PlayerData;
    
    public void GameOFF()
    {
        Application.Quit();
        Debug.Log("Is turning off BUT Cant thanks to Unity's shitty playmode :)");
    }
    public void Combine()
    {
        if (lever.fusion1 == true)
        {
            Debug.Log("combined item 1 n 2");
           PlayerData.tool1 = true;
            lever.item1.isOn = false;
            lever.item2.isOn = false;
            lever.item3.isOn = false;
            lever.item4.isOn = false;
        }

        if (lever.fusion2 == true)
        {
            Debug.Log("combined item 3 n 4");
           PlayerData.tool2 = true;
            lever.item1.isOn = false;
            lever.item2.isOn = false;
            lever.item3.isOn = false;
            lever.item4.isOn = false;
        }
      



    }

    /*
    public void ButtonforItem1()
    {
        Debug.Log("Clicked on button1");
        player.item = true;
    }


    public void ButtonforItem2()
    {
        Debug.Log("Clicked on button2");
        player.item2 = true;
    }


    public void stop()
    {
        StopCoroutine(timer());
        StopAllCoroutines();
        Debug.Log("stopped hovering over.");
    }
    public void hover()
    {
        Debug.Log("Currently located above button");
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Hovering above button for amount of time");
    }


    */
}
