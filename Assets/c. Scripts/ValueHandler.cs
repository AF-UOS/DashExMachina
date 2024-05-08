using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueHandler : MonoBehaviour
{
    public int room = 0;
    public float time;
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
        SceneManager.UnloadSceneAsync(roomName);
        SceneManager.LoadScene(roomName, LoadSceneMode.Additive);
    }
}
