using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    public CameraMovement cameraMovement;
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        var horizontalPress = Input.GetAxis("Horizontal");
        var verticalPress = Input.GetAxis("Vertical");

        // Get direction
        var cameraDirection = cameraMovement.transform.forward;
        var cameraDirectionCross = Vector2.Perpendicular(new Vector2(cameraDirection.x, cameraDirection.z));
        var directionPerpendicular = new Vector3(-cameraDirectionCross.x, 0, -cameraDirectionCross.y);
        var newPositionForward = new Vector3(verticalPress, 0, verticalPress);
        var newPositionSide = new Vector3(horizontalPress, 0, horizontalPress);

        var finalPosition = new Vector3(
            (newPositionForward.x * cameraDirection.x) + (newPositionSide.x * directionPerpendicular.x),
            0,
            (newPositionForward.z * cameraDirection.z) + (newPositionSide.z * directionPerpendicular.z)
        ).normalized * (movementSpeed * Time.fixedDeltaTime);
        

        rb.MovePosition(
            new Vector3(
                transform.position.x + finalPosition.x, 
                transform.position.y, 
                transform.position.z + finalPosition.z)
        );
    }
}
