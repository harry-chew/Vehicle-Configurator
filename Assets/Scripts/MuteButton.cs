using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    [SerializeField] private bool isClicked = false;

    [SerializeField] private GameObject soundOn, soundOff;

    public delegate void OnMuteClick(bool mute);
    public static OnMuteClick onMuteClick;
    //ButtongToggle function for unity editor


    private void Start()
    {
        var button = GetComponent<Button>();

        button.onClick.AddListener(ButtonToggle);
    }
    private void ButtonToggle()
    {
        if (isClicked)
        {
            isClicked = false;
            Mute(false);
        }
        else
        {
            isClicked = true;
            Mute(true);
        }
    }

    private void Mute(bool mute)
    {
        onMuteClick?.Invoke(mute);
        if (mute)
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        } 
        else if(!mute)
        {
            soundOff.SetActive(false);
            soundOn.SetActive(true);
        }
        else
        {
            Debug.Log("This should never run...");
        }
    }
}
