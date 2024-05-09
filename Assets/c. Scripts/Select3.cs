using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select3 : MonoBehaviour
{
    private ValueHandler script;

    private void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
    }

    public void Button()
    {
        script.room = 3;
        SceneManager.LoadScene("L_03_Intro", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("LevelSelect");
    }
}
