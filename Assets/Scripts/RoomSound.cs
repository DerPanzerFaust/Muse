using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSound : MonoBehaviour
{
    public AudioSource RoomMusic;
    public AudioSource missClick;
    private void Start()
    {
        RoomMusic.Play();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            missClick.Play();
        }
            
    }
}
