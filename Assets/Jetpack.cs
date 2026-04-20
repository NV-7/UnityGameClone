using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Jetpack : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D rb;
    public float speed;
    public GameObject coinText;
    public GameObject disanceText;
    public GameObject gameOverCanvas;
    int coinCounter = 0;
    int distance = 0;
    public int highScore;
    private Boolean gameOver = false;
    public Boolean speeding = false;
   
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        speed = 5f;
        highScore = PlayerPrefs.GetInt("Highscore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                restart();
            }
        }
       
    }
    private void FixedUpdate()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            fly();
        }
        if(speeding == false)
        {
            distance++;
            UpdateDistance();
        }else if(speeding == true)
        {
            distance += 2;
            UpdateDistance();
        }

            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Coin")
        {
            coinCounter++;
            UpdateCoin();
            Destroy(collision.gameObject);

        }
        if (tag.Equals("Missile"))
        {
            if (coinCounter > highScore)
            {
                highScore = coinCounter;
                PlayerPrefs.SetInt("Highscore", highScore);
                PlayerPrefs.Save();
            }

            
            gameOver = true;
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0;

            
            TextMeshProUGUI gameOverText = gameOverCanvas.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            if (gameOverText != null)
            {
                gameOverText.text += "\nScore: " + coinCounter;
                gameOverText.text += "\nHighscore: " + highScore;
            }

            Debug.Log("Game Over");
        }
    }

    void fly()
    {
        Vector2 upForce = new Vector2(0, 10);
        rb.AddForce(upForce* speed);
    }

    void UpdateDistance()
    {
        disanceText.GetComponent<TextMeshProUGUI>().text = distance + "m";
    }

    
    void UpdateCoin()
    {
        
        coinText.GetComponent<TextMeshProUGUI>().text = "Coins: " + coinCounter;
    }

    void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
