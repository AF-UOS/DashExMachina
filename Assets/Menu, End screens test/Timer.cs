using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text Time;
    public float time1val = 0f;
    public float time2val = 0f;
    public int room;

    private void Start()
    {
        room = 1;
    }
    void FixedUpdate()
    {
        //if statement for testing purposes, will use room value in a later version
        if (time1val < 2)
        {
            time1val += 0.01f;
            Time.text = "Time: " + time1val.ToString("00.00");
        }
        else if (time2val < 3)
        {
            time2val += 0.01f;
            Time.text = "Time: " + time2val.ToString("00.00");
        }
        else
        {
            SceneManager.LoadScene("End");
        }
    }
}