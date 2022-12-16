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
        //transform.position += 
        //    new Vector3(horizontalPress, verticalPress, transform.position.z).normalized * (movementSpeed * Time.deltaTime);
        var newPosition = new Vector3(horizontalPress, transform.position.y, verticalPress).normalized * (movementSpeed * Time.fixedDeltaTime);
        rb.MovePosition(transform.position + newPosition);
    }
}
