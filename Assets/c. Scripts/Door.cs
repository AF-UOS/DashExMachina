using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private Remaining script1;
    private PlayerController script2;

    void Start()
    {
        GameObject remaining = GameObject.Find("Counter 2");
        script1 = remaining.GetComponent<Remaining>();
        script1.Reset();
        GameObject controller = GameObject.Find("PlayerTest");
        script2 = controller.GetComponent<PlayerController>();
    }

    //Need to adjust collision
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (script1.remaining == 0)
            {
                //Load next room
                SceneManager.LoadScene("TEST.Coding");
                script1.Reset();
                script2.Reset();
            }
        }
    }
}
