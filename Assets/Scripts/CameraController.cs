using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform[] cameraPositions;
    [SerializeField]
    private Transform mainCamera;

    [SerializeField]
    private int currentCameraPosition = 0;


    [SerializeField] private bool canRotate;
    private void OnEnable()
    {
        PointRotateCamera.onRotateClick += ChangeCameraPosition;
    }

    private void OnDisable()
    {
        PointRotateCamera.onRotateClick -= ChangeCameraPosition;
    }

    private void Start()
    {
        canRotate = true;
        currentCameraPosition = 1;
        mainCamera = transform;

        RotateCamera(currentCameraPosition);
    }
    private void ChangeCameraPosition(PointRotateCamera.ButtonPosition button)
    {
        if(button == PointRotateCamera.ButtonPosition.Left)
        {
            currentCameraPosition -= 1;
        }
        if(button == PointRotateCamera.ButtonPosition.Right)
        {
            currentCameraPosition += 1;
        }

        if(currentCameraPosition > cameraPositions.Length - 1)
        {
            currentCameraPosition = 0;
        }
        if(currentCameraPosition < 0)
        {
            currentCameraPosition = cameraPositions.Length - 1;
        }

        RotateCamera(currentCameraPosition);
    }

    private void RotateCamera(int pos)
    {
        mainCamera.position = cameraPositions[pos].position;
        mainCamera.rotation = cameraPositions[pos].rotation;
    }

}
