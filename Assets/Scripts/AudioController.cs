using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioClip backgroundMusic;
    private void OnEnable()
    {
        MuteButton.onMuteClick += MuteAudio;
    }

    private void OnDisable()
    {
        MuteButton.onMuteClick -= MuteAudio;
    }

    private void MuteAudio(bool mute)
    {
        if(mute)
        {
            Debug.Log("Mute the audio");
        }
        else if(!mute)
        {
            Debug.Log("UnMute the audio");
        }
    }
}
