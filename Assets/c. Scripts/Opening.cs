using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour
{
    private ButtonCounter script;
    public int direction;
    float distance;
    float origin;

    void Start()
    {
        GameObject counter = GameObject.Find("Button Counter");
        script = counter.GetComponent<ButtonCounter>();
        if (transform.eulerAngles.y == 0 || transform.eulerAngles.y == 180)
        {
            origin = transform.position.x;
            if (transform.eulerAngles.y == 180)
            {
                direction = direction;
            }
        }
        else if (transform.eulerAngles.y  == 90 || transform.eulerAngles.y == 270)
        {
            origin = transform.position.z;
            if (transform.eulerAngles.y == 90)
            {
                direction = direction;
            }
        }
    }

    void FixedUpdate()
    {
        if (transform.eulerAngles.y == 0 || transform.eulerAngles.y == 180)
        {
            distance = ((transform.position.x - origin) * direction);
        }
        else if (transform.eulerAngles.y == 90 || transform.eulerAngles.y == 270)
        {
            distance = ((transform.position.z - origin) * direction);
        }
        if (script.num == script.max & distance < 1.5f)
        {
            transform.Translate(0.1f * direction, 0, 0);
        }
    }
}
