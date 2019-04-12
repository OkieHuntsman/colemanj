using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextFile : MonoBehaviour
{
    void CreateText()
    {
        string path = Application.dataPath + "/Scores.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Scores\n\n");
        }

        string content = "Scores: " + System.DateTime.Now + "\n";

        File.AppendAllText(path, content);
    }

    // Start is called before the first frame update
    void Start()
    {
        CreateText();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
