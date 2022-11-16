using UnityEngine;

public class PointRotateCamera : MonoBehaviour
{
    public enum ButtonPosition { Left, Right };
    [SerializeField] 
    private ButtonPosition button;

    public delegate void OnRotateClick(ButtonPosition button);
    public static OnRotateClick onRotateClick;

    private void OnMouseDown()
    {
        ChangeCameraPosition(button);
    }
    void ChangeCameraPosition(ButtonPosition button)
    {
        onRotateClick?.Invoke(button);
    }
}
 