using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public bool leftlimitreached;
    public bool rightlimitreached;



    public void Update()
    {
        if (Input.GetKey("left") && leftlimitreached == false)
        {
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey("right")&& rightlimitreached == false)
        {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);
        }
        if (transform.position.x < -14.88f)
        {
            rightlimitreached = true;

        }
        else
        {
            rightlimitreached = false;

        }
        if (transform.position.x > 5.05f) 
        {
            leftlimitreached = true;

        }
        else
        {
            leftlimitreached = false;


        }

    }
}
