using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentBuilder : MonoBehaviour
{
    public GameObject buttonTemplate;
    public ComponentType type;
    private void Start()
    {
       List<ICarComponent> components = CarManager.GetInstance().GetCarComponents(type);
       foreach(var component in components)
        {
            var button = Instantiate(buttonTemplate, transform);
            button.GetComponent<ComponentButton>().Create(component);
        }

        buttonTemplate.SetActive(false);
    }
}
