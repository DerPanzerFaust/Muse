using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject buttons;
   public void buttonmoment()
    {
        Debug.Log("Clicked on button");
        Destroy(buttons);
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
