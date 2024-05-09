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
        float time = script.time;
        Time.text = time.ToString("00.00");
        script.time = 0;
    }
}
