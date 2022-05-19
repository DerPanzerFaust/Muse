using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatCube : MonoBehaviour
{

    public Transform player;

    private void Update()
    {
        transform.LookAt(player);
    }

    private void OnMouseDown()
    {
        transform.position = new Vector3(0, 0.5f, -2.5f);

        Debug.Log("clicked");
    }
}
