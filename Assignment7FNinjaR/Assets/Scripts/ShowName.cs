using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    public Text display;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("", PlayerPrefs.GetString("username"));
        
        display.text = PlayerPrefs.GetString("username");


    }

}

