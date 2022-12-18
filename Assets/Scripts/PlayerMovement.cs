using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        var horizontalPress = Input.GetAxis("Horizontal");
        var verticalPress = Input.GetAxis("Vertical");

        var newPosition = new Vector3(horizontalPress, 0, verticalPress).normalized * (movementSpeed * Time.fixedDeltaTime);
        rb.MovePosition(new Vector3(transform.position.x + newPosition.x, transform.position.y, transform.position.z + newPosition.z));
    }
}
