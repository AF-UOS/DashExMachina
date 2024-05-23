using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    private ValueHandler script;
    string newRoom;

    void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            int room = script.room;
            if (room == 0 || room == 8)
            {
                newRoom = "L_01_Intro";
            }
            if (room == 1)
            {
                newRoom = "L_02_bend";
            }
            if (room == 2)
            {
                newRoom = "L_03_fork";
            }
            if (room == 3)
            {
                newRoom = "L_04_square";
            }
            if (room == 4)
            {
                newRoom = "L_05_hole";
            }
            if (room == 5)
            {
                newRoom = "L_06_circle";
            }
            if (room == 6)
            {
                newRoom = "L_07_saws";
            }
            if (room == 7)
            {
                newRoom = "L_08_bowtie";
            }
            if (room == 8)
            {
                newRoom = "TitleScene";
                script.room = -1;
            }
            SceneManager.LoadScene(newRoom, LoadSceneMode.Additive);
            script.room += 1;
            SceneManager.UnloadSceneAsync("ClearScene");
        }
    }

    public void Button()
    {
        int room = script.room;
        if (room == 0)
        {
            newRoom = "L_01_Intro";
        }
        if (room == 1)
        {
            newRoom = "L_02_bend";
        }
        if (room == 2)
        {
            newRoom = "L_03_fork";
        }
        if (room == 3)
        {
            newRoom = "L_04_square";
        }
        if (room == 4)
        {
            newRoom = "L_05_hole";
        }
        if (room == 5)
        {
            newRoom = "L_06_circle";
        }
        if (room == 6)
        {
            newRoom = "L_07_saws";
        }
        if (room == 7)
        {
            newRoom = "L_08_bowtie";
        }
        if (room == 8)
        {
            newRoom = "TitleScene";
            script.room = -1;
        }
        SceneManager.LoadScene(newRoom, LoadSceneMode.Additive);
        script.room += 1;
        SceneManager.UnloadSceneAsync("ClearScene");
    }
}
