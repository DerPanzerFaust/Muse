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
}
