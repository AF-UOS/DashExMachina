using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TMP_Text Time;
    public float time = 0f;

    void FixedUpdate()
    {
        time += 0.01f;
        Time.text = "Time: " + time.ToString("00.00");
    }
}