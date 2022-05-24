using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Rotate(new Vector3(0, -150, 0) * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(new Vector3(0, 150, 0) * Time.deltaTime);
        }
    }
}
