using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectComponentOnClick : MonoBehaviour
{
    [SerializeField] private int selectedComponentID;

    public delegate void OnSelectComponent(int selectedComponentID);
    public static OnSelectComponent onSelectComponent;

    public void OnMouseDown()
    {
        SelectComponent(selectedComponentID);
    }

    private void SelectComponent(int selectedComponentID)
    {
        onSelectComponent?.Invoke(selectedComponentID);
    }

}
