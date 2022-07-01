using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isCollected : MonoBehaviour
{
    public bool IsCollected = false;
    // Start is called before the first frame update
    void Start()
    {
        IsCollected = true;
     
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCollected == true)
        {
            Debug.Log("collectedTrue");
        }   
    }

}
