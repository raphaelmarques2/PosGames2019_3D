using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCar : MonoBehaviour
{

    Rigidbody rb;

    public float moveSpeed = 10;
    public float turnSpeed = 15;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Move(v);
        Turn(h);
    }

    void Move(float input)
    {
        var vel = rb.velocity;//pega velocidade global
        var rotation = rb.rotation;//pega rotação

        //converte velocidade de global pra local
        var localVelocity = Quaternion.Inverse(rotation) * vel;
        localVelocity.z = input * moveSpeed;//muda o z(frente) local
        localVelocity.x = 0;//remove inercia lateral

        //converte de local pra global
        var globalVelocity = rotation * localVelocity;

        //aplica velocidade global
        rb.velocity = globalVelocity;
    }

    void Turn(float input)
    {
        var vel = rb.angularVelocity;
        vel.y = input * turnSpeed;
        rb.angularVelocity = vel;
    }
}
