using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passarinho : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", v);

        bool a = Input.GetKey(KeyCode.A);
        animator.SetBool("Apontar", a);

        if (Input.GetKeyDown(KeyCode.X))
            animator.SetTrigger("Apontar2");

    }
}
