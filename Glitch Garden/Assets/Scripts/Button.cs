using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Loads Game scene
    public void LoadGameScene()
    {
        print("pressed");
        SceneManager.LoadScene("Game");
    }

    // Quits game
    public void QuitGame()
    {
        Application.Quit();
    }
}
