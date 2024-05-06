using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ValueHandler : MonoBehaviour
{
    public int room = 0;
    public float time;

    void Start()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
    }
}
