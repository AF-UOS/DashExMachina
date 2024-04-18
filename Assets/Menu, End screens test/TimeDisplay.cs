using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TMP_Text Time1;
    public TMP_Text Time2;
    public TMP_Text Total;

    void Start()
    {
        //Pass in time values
        float time1val = 5F;
        float time2val = 7F;
        float totalval = time1val + time2val;
        Time1.text = time1val.ToString();
        Time2.text = time2val.ToString();
        Total.text = totalval.ToString();
    }
}
