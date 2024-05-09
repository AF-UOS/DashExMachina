using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonCounter : MonoBehaviour
{
    public TMP_Text counter;
    public int max;
    public int num = 0;

    void Start()
    {
        counter.text = num + "/" + max;
    }

    public void Press()
    {
        num++;
        counter.text = num + "/" + max;
    }
}
