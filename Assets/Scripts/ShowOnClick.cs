using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnClick : MonoBehaviour
{
    [SerializeField] private bool isShown = false;

    [SerializeField] private GameObject objToShow;

    public void OnClick()
    {
        ShowToggle();
        Debug.Log("click");
    }

    public void ShowToggle()
    {
        if (isShown)
        {
            Show(false);
            isShown = false;
        }
        else
        {
            Show(true);
            isShown = true;
        }
    }

    private void Show(bool show)
    {
        if(show)
        {
            objToShow.SetActive(true);
        }
        else
        {
            objToShow.SetActive(false);
        }
    }
}
