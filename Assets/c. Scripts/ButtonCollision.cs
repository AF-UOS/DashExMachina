using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollision : MonoBehaviour
{

    private Total script1;
    private Remaining script2;
    int active = 1;

    void Start()
    {
        GameObject total = GameObject.Find("Counter 1");
        script1 = total.GetComponent<Total>();
        GameObject remaining = GameObject.Find("Counter 2");
        script2 = remaining.GetComponent<Remaining>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (active == 1)
            {
                script1.Press();
                script2.Press();
                active = 0;
            }
        }
    }
}
