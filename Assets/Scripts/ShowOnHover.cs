using UnityEngine;
using UnityEngine.EventSystems;

public class ShowOnHover : MonoBehaviour
{
    [SerializeField] private GameObject objToShow;

    public delegate void OnHoverUI();
    public static OnHoverUI onHoverUI;

    public void OnMouseEnter()
    {
        onHoverUI?.Invoke();
    }

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
