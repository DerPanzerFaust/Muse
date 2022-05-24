using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sliderscript : MonoBehaviour
{
    public Slider sliding;
    public TextMeshProUGUI slidertext;

    void Start()
    {
        sliding.onValueChanged.AddListener((v) =>
        {
            slidertext.text = v.ToString("0.00");

        });  
    }

}

