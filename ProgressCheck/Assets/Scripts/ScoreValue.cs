using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreValue : MonoBehaviour
    
{
    public int scoreVariable = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plus")
        {
            scoreVariable++;
            Destroy(collision.gameObject);
            if (scoreVariable > 10)
            {
                SceneManager.LoadScene("Win");
            }

        }
        else if (collision.gameObject.tag == "Minus")
        {
            scoreVariable--;
            Destroy(collision.gameObject);
            if (scoreVariable < -10)
            {
                SceneManager.LoadScene("LevelOne");

            }
        }
        
          
    }
    
}
