using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookClicks : MonoBehaviour
{
    public GameObject BookRed;
    public GameObject BookBlue;
    public GameObject BookBrown;
    public GameObject BookGreen;
    public GameObject BookOran;
    private void OnMouseDown()
    {
        if (gameObject.tag == "Red")
        {
            BookRed.SetActive(true);
            Debug.Log("AAAA");


        }
        if (gameObject.tag == "Blue")
        {

            BookBlue.SetActive(true);
        }
        if (gameObject.tag == "Brown")
        {
            BookBrown.SetActive(true);

        }
        if (gameObject.tag == "Green")
        {
            BookGreen.SetActive(true);

        }
        if (gameObject.tag == "Oran")
        {

            BookOran.SetActive(true);
        }

    }
}