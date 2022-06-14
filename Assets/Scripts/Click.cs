using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public PlayerData playerdata;

    public Transform player;
    public GameObject aPrefab;

   

    private void Update()
    {
       
    }

    

    private void OnMouseDown()
    {
        if (gameObject.tag == "item1")
        {
            playerdata.item = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(0.1594f, 0.2912f, 1.38f), Quaternion.identity);

            Debug.Log("clicked");
        }

        if (gameObject.tag == "item2")
        {
            playerdata.item2 = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(-0.021f, 0.2912f, 1.38f), Quaternion.identity);

            Debug.Log("clicked2");
        }

        if (gameObject.tag == "Item3")
        {
            playerdata.item3 = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(-0.204f, 0.2912f, 1.38f), Quaternion.identity);

            Debug.Log("clicked 3");
        }
        if (gameObject.tag == "Item4")
        {
            playerdata.item4 = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(0.1594f, 0.544f, 1.38f), Quaternion.identity);

            Debug.Log("clicked 4");
        }
        if (gameObject.tag == "Item5")
        {
            playerdata.item5 = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(-0.021f, 0.544f, 1.38f), Quaternion.identity);

            Debug.Log("clicked 5");
        }
        if (gameObject.tag == "Item6")
        {
            playerdata.item6 = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(-0.204f, 0.544f, 1.38f), Quaternion.identity);

            Debug.Log("clicked 6");
        }
        if (gameObject.tag == "Item7")
        {
            playerdata.item7 = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(0.1594f, 0.785f, 1.38f), Quaternion.identity);

            Debug.Log("clicked 7");
        }
        if (gameObject.tag == "Item8")
        {
            playerdata.item8 = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(-0.021f, 0.785f, 1.38f), Quaternion.identity);

            Debug.Log("clicked 8");
        }
        if (gameObject.tag == "Item9")
        {
            playerdata.item9 = true;
            Destroy(gameObject);
            Instantiate(aPrefab, new Vector3(-0.204f, 0.785f, 1.38f), Quaternion.identity);

            Debug.Log("clicked 9");
        }
    }
}
