using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    static float inputx;
    static float inputy;
    static float rotation;
    static float clamp;

    void Start()
    {
        inputx = 0;
        inputx = 0;
        rotation = 0;
    }

    void Update()
    {
        inputx = Input.GetAxis("Mouse X") * 2;
        inputy = Input.GetAxis("Mouse Y") * -2;
        clamp = Mathf.Clamp(inputy, (-60f - rotation), (60f - rotation));
        transform.eulerAngles = new Vector3(transform.eulerAngles.x + clamp, transform.eulerAngles.y + inputx, 0);
        rotation -= inputy;
        Debug.Log(clamp);
    }
}
