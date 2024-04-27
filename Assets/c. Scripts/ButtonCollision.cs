using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollision : MonoBehaviour
{
    //Total script1;
    //Remaining script2;
    int active = 1;

    void Start()
    {
        GameObject total = GameObject.Find("Counter 1");
        GameObject remaining = GameObject.Find("Counter 2");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(1);
            if (active == 1)
            {
                //script1 = total.GetComponent<Total>();
                //script1.Press();
                //script2 = remaining.GetComponent<Remaining>();
                //script2.Press();
                active = 0;
            }
        }
    }
}
