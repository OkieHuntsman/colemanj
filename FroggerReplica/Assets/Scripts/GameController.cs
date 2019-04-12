using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    public InputField input;

    void Awake()
    {
        input = GameObject.Find ("InputField").GetComponent<InputField>();
    }

    public void GetInput(string name)
    {
        input.text = "";
    }
}
