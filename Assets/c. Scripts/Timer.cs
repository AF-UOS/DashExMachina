using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private ValueHandler script;
    public TMP_Text Time;
    public int time;
    public int seconds;
    public int minutes;

    void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
        time = script.time;
        seconds = script.seconds;
        minutes = script.minutes;
    }

    void FixedUpdate()
    {
        time += 2;
        if (time == 100)
        {
            seconds++;
            time = 0;
        }
        if (seconds == 60)
        {
            minutes++;
            seconds = 0;
        }
        //Time.text = minutes.ToString() + ":" + seconds.ToString() + ":" + time.ToString();
        Time.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + time.ToString("00");
        script.Add(time, seconds, minutes);
    }
}