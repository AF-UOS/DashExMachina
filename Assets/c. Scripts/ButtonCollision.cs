using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollision : MonoBehaviour
{
    private ButtonCounter script;
    int active = 1;

    void Start()
    {
        GameObject total = GameObject.Find("Button Counter");
        script = total.GetComponent<ButtonCounter>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (active == 1)
            {
                script.Press();
                transform.Translate(0, -0.25f, 0);
                active = 0;
            }
        }
    }
}
