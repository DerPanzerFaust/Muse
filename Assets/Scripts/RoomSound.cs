using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSound : MonoBehaviour
{
    public AudioSource RoomMusic;

    private void Start()
    {
        RoomMusic.Play();
    }
}
