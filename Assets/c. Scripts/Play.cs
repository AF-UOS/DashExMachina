using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void Button()
    {
        SceneManager.LoadScene("L_00_Tutorial", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("TitleScene");
    }
}
