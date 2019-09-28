using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTargetByClick : MonoBehaviour
{

    public Transform target;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            OnClick();
        }
    }

    void OnClick()
    {
        var mousePos = Input.mousePosition;
        var ray = Camera.main.ScreenPointToRay(mousePos);

        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo))
        {
            target.position = hitInfo.point;
        }
    }
}
