using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAudio : MonoBehaviour
{
    public AudioSource song;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            song.mute = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            song.mute = true;
        }
    }
}
