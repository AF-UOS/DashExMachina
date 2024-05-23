using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    float inputx;
    float inputy;
    float rotation;

    void Start()
    {
        inputx = 0;
        inputx = 0;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        inputx = Input.GetAxis("Mouse X") * 2;
        inputy = Input.GetAxis("Mouse Y") * -2;
        if ((rotation + inputy) < -60f)
        {
            inputy = Mathf.Clamp(inputy, inputy, 0f);
        }
        else if ((rotation + inputy) > 60f)
        {
            inputy = Mathf.Clamp(inputy, 0f, inputy);
        }
        transform.eulerAngles = new Vector3(transform.eulerAngles.x + inputy, transform.eulerAngles.y + inputx, 0);
        rotation -= inputy;
    }
}
