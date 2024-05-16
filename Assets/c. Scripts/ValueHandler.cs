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

    void Start()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
    }

    public void Reset()
    {
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
        SceneManager.UnloadSceneAsync(roomName);
        SceneManager.LoadScene(roomName, LoadSceneMode.Additive);
    }

    public void Add(int x, int y, int z)
    {
        time = x;
        seconds = y;
        minutes = z;
    }
}
