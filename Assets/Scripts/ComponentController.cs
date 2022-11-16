using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentController : MonoBehaviour
{
    private void OnEnable()
    {
        SelectComponentOnClick.onSelectComponent += ShowUI;
    }

    private void OnDisable()
    {
        SelectComponentOnClick.onSelectComponent -= ShowUI;
    }

    private void ShowUI(int selectedComponentID)
    {
        if(selectedComponentID == 1) {
            DisplayRimUI();
        }
        if(selectedComponentID == 2)
        {
            DisplayColourUI();
        }
    }

    private void DisplayRimUI() 
    { 

    }

    private void DisplayColourUI()
    {

    }

}
