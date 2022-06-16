using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screentaker : MonoBehaviour
{
    public Colour_game Screen1;
    public Colour_game Screen2;
    public Colour_game Screen3;
    public GameObject Hiddenitem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Screen1.won == true && Screen2.won == true && Screen3.won == true)
        {
            Hiddenitem.SetActive(true);
            Debug.Log("WIN!");
        }
    }
}
