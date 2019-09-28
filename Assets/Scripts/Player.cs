using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpSpeed = 5;

    public float walkSpeed = 5;

    public float turnSpeed = -180;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        //var dir = new Vector3(h, 0, v) * walkSpeed;
        Walk(v * walkSpeed);
        Turn(h * turnSpeed);
    }

    void Turn(float speed)
    {
        var rb = GetComponent<Rigidbody>();
        rb.angularVelocity = new Vector3(0, speed, 0);

    }

    void Walk(float speed)
    {
        var rb = GetComponent<Rigidbody>();

        var vel = rb.velocity;
        vel += this.transform.forward * speed;
        rb.velocity = vel;
    }

    void Jump()
    {
        var rb = GetComponent<Rigidbody>();

        var vel = rb.velocity;
        vel.y = jumpSpeed;
        rb.velocity = vel;

    }

}
