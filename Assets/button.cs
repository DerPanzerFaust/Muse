using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject buttons;
   public void buttonmoment()
    {
        Debug.Log("A");
        Destroy(buttons);
    }
    
    public void stop()
    {
        StopCoroutine(timer());
        StopAllCoroutines();
        Debug.Log("stopped");
    }
    public void hover()
    {
        Debug.Log("waws");
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("sopo");
    }



}
