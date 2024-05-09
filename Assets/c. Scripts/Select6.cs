using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select6 : MonoBehaviour
{
    private ValueHandler script;

    private void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
    }

    public void Button()
    {
        script.room = 6;
        SceneManager.LoadScene("L_06_MoveHaz", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("LevelSelect");
    }
}
