using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public static int hit = 0;
    Text scoreText;

    // Update is called once per frame
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = "Hit: " + hit;
    }
}
