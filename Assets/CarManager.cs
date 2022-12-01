using System;
using System.Collections.Generic;
using UnityEngine;
internal class CarManager : MonoBehaviour
{
    private static List<ICarComponent> carComponents = new();

    [SerializeField] private List<ICarComponent> myCarComponents;
    [SerializeField] private List<WheelRim> myWheelRims;

    private static CarManager Instance;
    public static CarManager GetInstance()
    {
        if(Instance != null)
        {
            return Instance;
        }
        else
        {
            Instance = FindObjectOfType<CarManager>();
            if(Instance != null)
            {
                return Instance;
            }
            else
            {
                Instance = new CarManager();
                return Instance;
            }
        }
    }

    private void Start()
    {
        Instance = this;

        foreach(ICarComponent component in myWheelRims)
        {
            carComponents.Add(component);
        }
    }

    public List<ICarComponent> GetCarComponents(ComponentType wheelRim)
    {
        return carComponents;
    }
}