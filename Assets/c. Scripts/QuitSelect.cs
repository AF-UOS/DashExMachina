using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitSelect : MonoBehaviour
{
    public void Button() {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("LevelSelect");
    }
}
