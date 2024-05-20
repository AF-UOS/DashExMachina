using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour
{
    private ButtonCounter script;
    public int direction;
    static int active;
    float origin;

    void Start()
    {
        GameObject counter = GameObject.Find("Button Counter");
        script = counter.GetComponent<ButtonCounter>();
        origin = transform.position.x;
    }

    void FixedUpdate()
    {
        if (script.num == script.max & (transform.position.x * direction) < (2.25 * (origin * direction)))
        {
            transform.Translate(0.1f * direction, 0, 0);
            Debug.Log(origin);
        }
    }
}
