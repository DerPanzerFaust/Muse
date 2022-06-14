using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour_game : MonoBehaviour
{
    public Material[] materialslist = new Material[6];
    //Material currentmaterial;
    public int cycle = 0;
    Renderer rend;
    public bool cycletrue = true;

    public bool Isred;

    public bool won;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        StartCoroutine(timer());
        cycletrue = true;
        won = false;
    }



    IEnumerator timer()
    {

        yield return new WaitForSeconds(0.8f);

        cycle += 1;
        StartCoroutine(timer());

    }

    private void OnMouseDown()
    {

        cycletrue = !cycletrue;


    }

    private void Update()
    {





        if (cycletrue == false && Isred == true)
        {
            won = true;
        }



        if (cycletrue == true)
        {

            if (cycle > 5)
            {
                cycle = 0;

            }

            if (gameObject.tag == "Screen2")
            {
                if (cycle == 5)
                {
                    Debug.Log("Is now red ");
                    Isred = true;
                }
                else
                {
                    Isred = false;
                }


            }
            if (gameObject.tag == "Screen3")
            {
                if (cycle == 0)
                {
                    Debug.Log("Is now red ");
                    Isred = true;
                }
                else
                {
                    Isred = false;
                }

            }

            else if (gameObject.tag == "Screen1")
            {
                if (cycle == 2)
                {
                    Debug.Log("Is now red ");
                    Isred = true;
                }
                else
                {
                    Isred = false;
                }


            }

            rend.sharedMaterial = materialslist[cycle];
        }

    }


}