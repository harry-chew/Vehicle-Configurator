using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComponentButton : MonoBehaviour
{
    private int id;
    private string name;
    private ComponentType type;
   
    public void Create(ICarComponent carComponent)
    {
        id = carComponent.GetId();
        name = carComponent.GetName();
        type = carComponent.GetType();

        transform.GetComponentInChildren<TextMeshProUGUI>().text = name;
        GetComponent<Button>().onClick.AddListener(ComponentSelected);
    }

    private void ComponentSelected()
    {
        Debug.Log(name);
        //carmanager.updatecomponet(id, type);
    }
}
