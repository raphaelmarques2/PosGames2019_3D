using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{

    public float speed;

    void Update()
    {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        var rot = new Vector3(-v, h, 0) * speed;

        this.transform.Rotate(rot * Time.deltaTime);

        var rot2 = this.transform.eulerAngles;
        rot2.z = 0;
        this.transform.eulerAngles = rot2;


    }

}
