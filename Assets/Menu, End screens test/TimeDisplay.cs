using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text time1;
    public TMP_Text time2;
    public TMP_Text total;

    void Start()
    {
        //This line should work
        GameObject go = GameObject.FindWithTag("Time");

        //I think it can't find the script in these lines
        float time1val = go.GetComponent<Timer>().time1val;
        float time2val = go.GetComponent<Timer>().time2val;

        float totalval = time1val + time2val;
        time1.text = time1val.ToString("00.00");
        time2.text = time2val.ToString("00.00");
        total.text = totalval.ToString("00.00");
    }
}
