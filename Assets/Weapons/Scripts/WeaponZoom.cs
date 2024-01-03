using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomInSensitivity = 1f;
    [SerializeField] float zoomOutSensitivity = 2f;

    FirstPersonController fpsController;

    bool zoomedInToggle = false;


    void Start()
    {
        fpsController = GetComponent<FirstPersonController>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                fpsController.RotationSpeed = zoomInSensitivity;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                fpsController.RotationSpeed = zoomOutSensitivity;
            }
        }
    }


}
