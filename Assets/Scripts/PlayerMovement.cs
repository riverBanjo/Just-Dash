using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public InputAction moveAction;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;

    public bool moveRight = false;

    public bool moveLeft = false;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        Console.WriteLine("HELLO");
    }

    void Update()
    {
        moveRight = moveAction.ReadValue<Vector2>().x > 0;
        moveLeft = moveAction.ReadValue<Vector2>().x < 0;
    }
    
    void FixedUpdate()
    {
        // Add a forward force to the player
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( moveRight )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if ( moveLeft )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
