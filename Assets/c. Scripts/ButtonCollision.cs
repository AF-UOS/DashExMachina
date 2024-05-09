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
                active = 0;
            }
        }
    }
}
