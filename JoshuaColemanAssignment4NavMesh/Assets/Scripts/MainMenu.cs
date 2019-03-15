using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void Loss()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void StartScreen()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public void Thanks()
    {
        SceneManager.LoadScene("Thanks");
    }
}
