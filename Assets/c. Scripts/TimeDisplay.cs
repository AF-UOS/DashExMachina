using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    private ValueHandler script;
    public TMP_Text time;

    void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
        float timeval = script.time;
        time.text = timeval.ToString("00.00");
    }
}
