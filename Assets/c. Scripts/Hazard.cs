using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private ValueHandler script1;
    private Camera script2;
    private PlayerController script3;

    void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script1 = go.GetComponent<ValueHandler>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            script1.Reset();
        }
    }
}
