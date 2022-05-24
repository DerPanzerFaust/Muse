using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject buttons;
    public PlayerData player;
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
    public void Combine()
    {
        if (player.item == true && player.item2 == true)
        {
            Debug.Log("combined");
        }
        else
        {
            Debug.Log("No items to combine");
        }
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



}
