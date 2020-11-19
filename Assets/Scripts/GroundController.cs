using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GroundController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int turnSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }



    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementY, 0.0f, -movementX);
        transform.Rotate(movement * turnSpeed * Time.deltaTime);
    }

}
