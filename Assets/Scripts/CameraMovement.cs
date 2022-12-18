using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float mouseX = 0f;
    public float mouseY = 0f;
    public float movementSensitivity = 1f;

    private Camera santaCamera;
    void Start()
    {
        santaCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // var mousePosition = Input.mousePosition;
        // var viewPointPosition = santaCamera.ScreenToViewportPoint(mousePosition);

        // var xMovement = Mathf.Clamp(viewPointPosition.x, 0, 1);
        // var yMovement = Mathf.Clamp(viewPointPosition.y, 0, 1);

        var cameraObject = santaCamera.gameObject.transform;

        mouseX += Input.GetAxis("Mouse X") * movementSensitivity;
        mouseY += Input.GetAxis("Mouse Y") * movementSensitivity;

        cameraObject.rotation = Quaternion.Euler(-mouseY, mouseX, 0);
    }
}
