using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Button()
    {
        SceneManager.LoadScene("LevelSelect", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("TitleScene");
    }
}
