using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private string channel;

    public delegate void OnSliderChange(float vol, string channel);
    public static OnSliderChange onSliderChange;
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            onSliderChange?.Invoke(slider.value, channel);
        });
    }

}
