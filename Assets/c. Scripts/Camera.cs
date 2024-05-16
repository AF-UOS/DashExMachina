using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    static float inputX;
    static float inputY;
    void Start()
    {
        inputX = 0;
        inputY = 0;
    }

    void Update()
    {
        inputX = Input.GetAxis("Mouse X") * 2;
        inputY = Input.GetAxis("Mouse Y") * 2;
        //transform.rotation = Quaternion.Euler(inputY, inputX, 0);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x + -inputY, transform.eulerAngles.y + inputX, 0);
        //Mathf.Clamp() // research this
        //transform.Rotate(rotationVector);
    }
}
