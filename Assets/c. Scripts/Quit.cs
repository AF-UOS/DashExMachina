using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("ClearScene");
        }
    }

    public void Button()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("ClearScene");
    }
}
