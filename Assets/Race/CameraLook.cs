using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public Transform target;
    
    void LateUpdate()
    {
        this.transform.LookAt(target);
    }
}
