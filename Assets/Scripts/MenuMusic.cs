using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    public AudioSource menuMusic;

    private void Start()
    {
        menuMusic.Play();
    }
}
