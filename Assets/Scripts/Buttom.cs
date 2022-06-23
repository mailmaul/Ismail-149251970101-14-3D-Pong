using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttom : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Created by ISMAIL - 149251970101-14");
        SceneManager.LoadScene("Game");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
