using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Leveraction : MonoBehaviour
{
    public Toggle Toggler;

    public void Start()
    {
        Toggler.onValueChanged.AddListener(delegate { Togglecheck(Toggler); });

    }

    void Togglecheck(Toggle tglvalue)
    {
        Debug.Log("State:" + tglvalue.isOn);
    }

    public void Update()
    {
        
    }

}
