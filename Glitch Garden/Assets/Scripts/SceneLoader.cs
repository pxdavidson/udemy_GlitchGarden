using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    // Load game scene
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    // Quit game
    public void QuitTheGame()
    {
        Application.Quit();
    }
}
