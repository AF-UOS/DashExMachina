using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    private ValueHandler script;
    int room;
    string roomName;

    void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            room = script.room;
            if (room == 0)
            {
                roomName = "L_00_Tutorial";
            }
            else if (room == 1)
            {
                roomName = "L_01_Intro";
            }
            else if (room == 2)
            {
                roomName = "L_02_bend";
            }
            else if (room == 3)
            {
                roomName = "L_03_fork";
            }
            else if (room == 4)
            {
                roomName = "L_04_square";
            }
            else if (room == 5)
            {
                roomName = "L_05_hole";
            }
            else if (room == 6)
            {
                roomName = "L_06_circle";
            }
            else if (room == 7)
            {
                roomName = "L_07_saws";
            }
            else if (room == 8)
            {
                roomName = "L_08_bowtie";
            }
            else if (room == 9)
            {
                roomName = "L_09_spin";
            }
            SceneManager.LoadScene(roomName, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("ClearScene");
        }
    }
}
