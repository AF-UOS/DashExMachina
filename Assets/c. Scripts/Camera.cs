using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    static float input;

    void Start()
    {
        input = 0;
    }

    void Update()
    {
        input = Input.GetAxis("Mouse X") * 2;
        transform.Rotate(0, input, 0);
    }
}
