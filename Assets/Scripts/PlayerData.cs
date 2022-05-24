using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{


    public bool item = false;
    public bool item2 = false;

    // Start is called before the first frame update
    void Start()
    {

    }

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



    }
}
