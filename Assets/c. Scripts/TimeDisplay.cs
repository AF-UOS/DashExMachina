using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    private ValueHandler script;
    public TMP_Text Time;

    void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
        int time = script.time;
        int seconds = script.seconds;
        int minutes = script.minutes;
        Time.text = minutes.ToString() + ":" + seconds.ToString() + ":" + time.ToString();
        script.time = 0;
        script.seconds = 0;
        script.minutes = 0;
    }
}
