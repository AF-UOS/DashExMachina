using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private ButtonCounter script1;
    private ValueHandler script2;
    int room;
    string roomName;

    void Start()
    {
        GameObject counter = GameObject.Find("Button Counter");
        script1 = counter.GetComponent<ButtonCounter>();
        GameObject go = GameObject.Find("GameObject");
        script2 = go.GetComponent<ValueHandler>();
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player" & script1.num == script1.max)
        {
            room = script2.room;
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
                roomName = "L_02_bend";
            }
            if (room == 3)
            {
                roomName = "L_03_fork";
            }
            if (room == 4)
            {
                roomName = "L_04_square";
            }
            if (room == 5)
            {
                roomName = "L_05_hole";
            }
            if (room == 6)
            {
                roomName = "L_06_circle";
            }
            if (room == 7)
            {
                roomName = "L_07_saws";
            }
            if (room == 8)
            {
                roomName = "L_08_bowtie";
            }
            SceneManager.LoadScene("ClearScene", LoadSceneMode.Additive);
            Cursor.lockState = CursorLockMode.None;
            SceneManager.UnloadSceneAsync(roomName);
        }
    }
}
