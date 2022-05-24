using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatCube : MonoBehaviour
{

    public Transform player;
    public GameObject aPrefab;

    private void Update()
    {
        transform.LookAt(player);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(aPrefab, new Vector3(0.1594f, 0.2912f, 1.38f), Quaternion.identity);

        Debug.Log("clicked");
    }
}
