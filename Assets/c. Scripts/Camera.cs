using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    void Update()
    {
        float input = Input.GetAxis("Mouse X");
        Debug.Log(input);
        transform.Rotate(0, input, 0);
    }
}
