using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    void OnTriggerEnter2D()
    {
        Debug.Log("YOU WON!");
        Score.CurrentScore += 100; 
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        

        if(Score.CurrentScore == 10000000)
        {
            SceneManager.LoadScene("Win");
        }
	}

}
