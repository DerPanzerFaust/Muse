using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMaster : MonoBehaviour
{
    public void loadMaster(string Master)
    {
        SceneManager.LoadScene("Master");
        Debug.Log("quit!");
    }



    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(AfkKicker());
    }

    IEnumerator AfkKicker()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(60);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        SceneManager.LoadScene("Intro");
    }

}
