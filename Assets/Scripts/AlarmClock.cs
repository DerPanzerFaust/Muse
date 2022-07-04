using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmClock : MonoBehaviour
{
    public AudioSource Alarm;

    private void Start()
    {
        Alarm.Play();
    }
}
