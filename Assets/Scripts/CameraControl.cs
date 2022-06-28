using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public bool leftlimitreached;
    public bool rightlimitreached;
    public GameObject HelpDissapear;


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
        if (transform.position.x < -14.3f)
        {

            //transform.position = new Vector3 (5f, 0.3833332f, -112.3f);
            rightlimitreached = true;
            

        }
      

        else
        {
            rightlimitreached = false;

        }
        if (transform.position.x > 6.6f) 
        {
            leftlimitreached = true;

        }
        else
        {
            leftlimitreached = false;


        }




        if (rightlimitreached == true)
        {
            HelpDissapear.SetActive(false);
        }
        if (rightlimitreached == false)
        {
            HelpDissapear.SetActive(true);
        }

    }
}
