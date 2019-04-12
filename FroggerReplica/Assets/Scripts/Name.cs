using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    //public static int CurrentScore = 0;
    public static string input = "";

    //public Text scoreText;

    public Text user;

    void Start()
    {
        user.text = input.ToString();
       // scoreText.text = CurrentScore.ToString();
    }

}
