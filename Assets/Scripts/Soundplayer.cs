using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundplayer : MonoBehaviour
{
    public AudioSource Radio;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnMouseDown()
    {
        Radio.Play();

    
    }
}
