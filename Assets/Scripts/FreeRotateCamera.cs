using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeRotateCamera : MonoBehaviour
{
    [SerializeField] private Transform cameraPivotPoint;
    [SerializeField] private Transform mainCamera;
    [SerializeField] private Vector2 mousePosition;
    [SerializeField] private Vector2 currentMousePosition;

    [SerializeField] private float minClampX;
    [SerializeField] private float maxClampX;

    private void Start()
    {
        mainCamera = gameObject.transform;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;

            mainCamera.parent = cameraPivotPoint;
        }

        if(Input.GetMouseButtonUp(0))
        {
            cameraPivotPoint.DetachChildren();
        }
    }
    private void LateUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            currentMousePosition = Input.mousePosition;

            Vector2 norm = currentMousePosition.normalized;

            float lol = norm.x;
            cameraPivotPoint.Rotate(new Vector3(0, lol, 0));

        }
    }
}
