using UnityEngine;
using UnityEngine.EventSystems;

public class ShowOnHover : MonoBehaviour
{
    [SerializeField] private GameObject objToShow;

    public void OnMouseOver()
    {
        ShowObject(true);
    }

    public void OnMouseExit()
    {
        ShowObject(false);
    }

    private void ShowObject(bool show)
    {
        objToShow.SetActive(show);
    }
}
