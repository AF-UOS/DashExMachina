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
    }

    void FixedUpdate()
    {
        time += 1;
        if (time == 100)
        {
            seconds++;
            time = 0;
        }
        if (time == 60)
        {
            minutes++;
            seconds = 0;
        }
        Time.text = minutes.ToString() + ":" + seconds.ToString() + ":" + time.ToString();
        script.Add(time, seconds, minutes);
    }
}