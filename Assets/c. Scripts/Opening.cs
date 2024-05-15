using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opening : MonoBehaviour
{
    private ButtonCounter script;
    public int direction;
    static int active;

    void Start()
    {
        GameObject counter = GameObject.Find("Button Counter");
        script = counter.GetComponent<ButtonCounter>();
    }

    void FixedUpdate()
    {
        if (script.num == script.max & (transform.position.x * direction) < 2.25)
        {
            transform.Translate(0.1f * direction, 0, 0);
        }
    }
}
