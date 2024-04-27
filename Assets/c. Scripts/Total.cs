using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Total : MonoBehaviour
{
    public TMP_Text counter;
    int total = 0;

    public void Press()
    {
        total++;
        counter.text = "Total: " + total;
    }
}
