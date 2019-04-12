using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject frog1, frog2, frog3;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        frog1.gameObject.SetActive(true);
        frog2.gameObject.SetActive(true);
        frog3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                frog1.gameObject.SetActive(true);
                frog2.gameObject.SetActive(true);
                frog3.gameObject.SetActive(true);
                break;
            case 2:
                frog1.gameObject.SetActive(true);
                frog2.gameObject.SetActive(true);
                frog3.gameObject.SetActive(false);
                break;
            case 1:
                frog1.gameObject.SetActive(true);
                frog2.gameObject.SetActive(false);
                frog3.gameObject.SetActive(false);
                break;
            case 0:
                frog1.gameObject.SetActive(false);
                frog2.gameObject.SetActive(false);
                frog3.gameObject.SetActive(false);
                SceneManager.LoadScene("GameOver");
                break;

            
        }
       

    }

}
