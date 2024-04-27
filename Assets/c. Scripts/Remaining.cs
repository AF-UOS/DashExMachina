using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Remaining : MonoBehaviour
{
    public TMP_Text counter;
    //Value is set to max on room change
    public int max = 5;
    int remaining = 0;

    //Called on room change, potentially also death to a hazard
    void Reset()
    {
        remaining = max;
    }

    void Press()
    {
        remaining--;
        counter.text = "Remaining: " + remaining;
    }
}
