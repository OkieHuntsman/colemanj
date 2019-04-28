using UnityEngine;
using UnityEngine.UI;


public class Miss : MonoBehaviour
{
    public static int miss = 0;
    Text missText;

    // Update is called once per frame
    void Start()
    {
        missText = GetComponent<Text>();
    }

    void Update()
    {
        missText.text = "Missed: " + miss;
    }
}
