using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeToMain : MonoBehaviour
{
  void Start()
    {

    }

  void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }

        else if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Main");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Credits");
        }
    }

   public void ChangeSceneToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void ChangeSceneToInfo()
    {
        SceneManager.LoadScene("Info");
    }

    public void ChangeSceneToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
