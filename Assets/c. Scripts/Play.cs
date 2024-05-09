using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    private ValueHandler script;

    private void Start()
    {
        GameObject go = GameObject.Find("GameObject");
        script = go.GetComponent<ValueHandler>();
    }

    public void Button()
    {
        script.room = 0;
        SceneManager.LoadScene("L_00_Tutorial", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("TitleScene");
    }
}
