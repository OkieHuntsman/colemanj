using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public GameObject name;
    public string Username;

    void Update()
    {
        Username = name.GetComponent<InputField>().text;
    }

    public void GamePlay()
    {
        PlayerPrefs.SetString("username", Username);
        SceneManager.LoadScene("Exit");
    }
}

