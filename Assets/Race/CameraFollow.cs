using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float speed = 25;

    void Start()
    {
        this.transform.position = target.position;
    }

    void LateUpdate()
    {
        var newPos =
            Vector3.MoveTowards(
                this.transform.position, 
                target.position, 
                speed * Time.deltaTime
            );
        
        this.transform.position = newPos;
    }
}
