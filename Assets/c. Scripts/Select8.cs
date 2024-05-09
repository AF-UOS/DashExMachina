using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select8 : MonoBehaviour
{
    private ValueHandler script;

    private void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
    }

    public void Button()
    {
        script.room = 8;
        SceneManager.LoadScene("L_08_MoveHaz", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("LevelSelect");
    }
}
