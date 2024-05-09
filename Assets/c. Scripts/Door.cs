using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private ButtonCounter script1;
    private PlayerController script2;
    private ValueHandler script3;
    int room;
    string roomName;

    void Start()
    {
        GameObject remaining = GameObject.Find("Counter 2");
        script1 = remaining.GetComponent<ButtonCounter>();
        GameObject controller = GameObject.Find("PlayerTest");
        script2 = controller.GetComponent<PlayerController>();
        GameObject go = GameObject.Find("GameObject");
        script3 = go.GetComponent<ValueHandler>();
    }

    //Need to adjust collision
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            if (script1.num == script1.max)
            {
                room = script3.room;
                if (room == 0)
                {
                    roomName = "L_00_Tutorial";
                }
                if (room == 1)
                {
                    roomName = "L_01_Intro";
                }
                if (room == 2)
                {
                    roomName = "L_02_Intro";
                }
                if (room == 3)
                {
                    roomName = "L_03_Intro";
                }
                if (room == 4)
                {
                    roomName = "L_04_StaticHaz";
                }
                if (room == 5)
                {
                    roomName = "L_05_StaticHazard";
                }
                if (room == 6)
                {
                    roomName = "L_06_MovHazard";
                }
                if (room == 7)
                {
                    roomName = "L_07_MovHazard";
                }
                if (room == 8)
                {
                    roomName = "L_08_MovHazard";
                }
                SceneManager.LoadScene("ClearScene", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(roomName);
            }
        }
    }
}
