using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public Text healthText;
    public Slider healthhamSlider;
    public int lives = 10;

    private void Start()
    {
        healthText.text = "Healthly Pumpkin Sir: " + health;
        healthhamSlider.maxValue = health;
        healthhamSlider.value = health;
        PlayerPrefs.SetInt("lives", lives);
        lives = PlayerPrefs.GetInt("lives");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Healthly Pumpkin Sir: " + health;
            healthhamSlider.value = health;
            if(health < 1) 
            {
                if (lives > 0)
                {


                    SceneManager.LoadScene("Lose");
                      
                    //SceneManager.LoadScene("Lose");
                    PlayerPrefs.SetInt("lives", lives - 1);
                }
                else
                {
                    SceneManager.LoadScene("Game Over");
                }
            }
        
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            healthText.text = "Healthly Pumpkin Sir: " + health;
            healthhamSlider.value = health;

            if (health < 1)
            {
                SceneManager.LoadScene("Lose");

                
            }
        }
    }

}
