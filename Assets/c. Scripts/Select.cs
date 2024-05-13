using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    private ValueHandler script;
    public string room;

    private void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
    }

    public void Button()
    {
        script.room = 1;
        SceneManager.LoadScene(room, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("LevelSelect");
    }
}
