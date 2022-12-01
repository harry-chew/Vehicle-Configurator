using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class WheelRim : ICarComponent {
    [SerializeField] private double componentPrice;
    [SerializeField] private string componentName;
    [SerializeField] private int id;
    [SerializeField] private ComponentType componentType;

    public int GetId()
    {
        return id;
    }

    public string GetName()
    {
        return componentName;
    }

    ComponentType ICarComponent.GetType()
    {
        return componentType;
    }
}
