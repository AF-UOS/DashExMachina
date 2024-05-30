using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueHandler : MonoBehaviour
{
    public int room = 0;
    public int time;
    public int seconds;
    public int minutes;
    string roomName;
    public int active = 0;

    void Start()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
    }

    void Update()
    {
        if (active == 1)
        {
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
            //else if (room == 10)
            //{
                //roomName = "L_10_spiral";
            //}
            SceneManager.UnloadSceneAsync(roomName);
            SceneManager.LoadScene(roomName, LoadSceneMode.Additive);
            active = 0;
        }
    }

    public void Add(int x, int y, int z)
    {
        time = x;
        seconds = y;
        minutes = z;
    }
}
