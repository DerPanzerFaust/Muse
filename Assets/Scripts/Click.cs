using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public PlayerData playerdata;

    public Transform player;
    public GameObject aPrefab;

    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;
    public GameObject Item6;
    public GameObject Item7;
    public GameObject Item8;
    public GameObject Item9;
    private void Update()
    {
       
    }

    

    private void OnMouseDown()
    {
        if (gameObject.tag == "item1")
        {
            playerdata.item = true;
            Destroy(gameObject);
            Item1.SetActive(true);

            Debug.Log("clicked");
        }

        if (gameObject.tag == "item2")
        {
            playerdata.item2 = true;
            Destroy(gameObject);
            Item2.SetActive(true);

            Debug.Log("clicked2");
        }

        if (gameObject.tag == "Item3")
        {
            playerdata.item3 = true;
            Destroy(gameObject);
            Item3.SetActive(true);

            Debug.Log("clicked 3");
        }
        if (gameObject.tag == "Item4")
        {
            playerdata.item4 = true;
            Destroy(gameObject);
            Item4.SetActive(true);

            Debug.Log("clicked 4");
        }
        if (gameObject.tag == "Item5")
        {
            playerdata.item5 = true;
            Destroy(gameObject);
            Item5.SetActive(true);

            Debug.Log("clicked 5");
        }
        if (gameObject.tag == "Item6")
        {
            playerdata.item6 = true;
            Destroy(gameObject);
            Item6.SetActive(true);

            Debug.Log("clicked 6");
        }
        if (gameObject.tag == "Item7")
        {
            playerdata.item7 = true;
            Destroy(gameObject);
            Item7.SetActive(true);

            Debug.Log("clicked 7");
        }
        if (gameObject.tag == "Item8")
        {
            playerdata.item8 = true;
            Destroy(gameObject);
            Item8.SetActive(true);

            Debug.Log("clicked 8");
        }
        if (gameObject.tag == "Item9")
        {
            playerdata.item9 = true;
            Destroy(gameObject);
            Item9.SetActive(true);

            Debug.Log("clicked 9");
        }
    }
}
