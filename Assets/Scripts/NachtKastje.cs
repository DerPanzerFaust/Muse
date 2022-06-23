using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NachtKastje : MonoBehaviour
{

    public GameObject row1;
    public GameObject row2;
    public GameObject row3;
    public PlayerData playerDatas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if(gameObject.tag == "1row" && playerDatas.IronKey == true)
        {
            Destroy(gameObject);
            row2.SetActive(true);
        }
        if (gameObject.tag == "2row")
        {
            Destroy(gameObject);
            row3.SetActive(true);
        }


    }
}
