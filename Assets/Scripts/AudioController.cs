using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource UIHoverSfx;
    [SerializeField] private AudioMixer audioMixer;

    private void OnEnable()
    {
        MuteButton.onMuteClick += MuteAudio;
        ShowOnHover.onHoverUI += PlayHoverAudio;
        SliderScript.onSliderChange += ChangeVolume;
    }
    private void OnDisable()
    {
        MuteButton.onMuteClick -= MuteAudio;
        ShowOnHover.onHoverUI -= PlayHoverAudio;
        SliderScript.onSliderChange -= ChangeVolume;
    }

    private void ChangeVolume(float vol, string channel)
    {
        if(channel == "sfx")
        {
            audioMixer.SetFloat("SfxVolume", vol);
        }
        if(channel == "music")
        {
            audioMixer.SetFloat("MusicVolume", vol);
        }
    }

    private void PlayHoverAudio()
    {
        UIHoverSfx.Play();
    }

    private void MuteAudio(bool mute)
    {
        if(mute)
        {
            Debug.Log("Mute the audio");
            audioMixer.SetFloat("MasterVolume", -80f);
        }
        else if(!mute)
        {
            Debug.Log("UnMute the audio");
            audioMixer.SetFloat("MasterVolume", 0f);
        }
    }
}
