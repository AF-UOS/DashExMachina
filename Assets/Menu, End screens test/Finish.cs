using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void Update()
    {
        //Condition for finish
        SceneManager.LoadScene("End");
    }
}
