using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlForce : MonoBehaviour
{
    ConstantForce force;

    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        force = GetComponent<ConstantForce>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            force.force = new Vector3(0, 20, 0);
            fire.SetActive(true);
        }
        else
        {
            force.force = new Vector3(0, 5, 0);
            fire.SetActive(false);
        }
    }
}
