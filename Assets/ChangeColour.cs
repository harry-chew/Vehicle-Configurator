
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    [SerializeField] private Renderer vehicleBody;
    public void OnMouseUp()
    {
        Debug.Log("Change Colour");
        ChangeMaterial();
    }

    private Color RandomMaterialColour()
    {
        float r = Random.Range(0, 1f);
        float g = Random.Range(0, 1f);
        float b = Random.Range(0, 1f);

        return new Color(r, g, b, 1f);
    }
    private void ChangeMaterial()
    {
        vehicleBody.GetComponent<Renderer>().material.SetColor("_Color", RandomMaterialColour());
        /*foreach (GameObject panel in BodyPanels.panels)
        {
            panel.GetComponent<Renderer>().material.SetColor("_Color", RandomMaterialColour());
        }*/

        // send message to BodyPanels script with colour to change
    }
}
