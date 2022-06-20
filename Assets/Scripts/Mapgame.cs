using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapgame : MonoBehaviour
{
    public GameObject reward;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        if (gameObject.tag == "MapDot")
        {
            Debug.Log("Miss - punt");
        }

        if (gameObject.tag == "MapWin")
        {
            Debug.Log("Win punt");
            reward.SetActive(true);
        }

    }
}