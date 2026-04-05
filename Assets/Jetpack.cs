using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jetpack : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D rb;
    public float speed;
    public GameObject coinText;
    public GameObject disanceText;
    int coinCounter = 0;
    int distance = 0;
    
   
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void FixedUpdate()
    {
        if (Keyboard.current.spaceKey.isPressed)
        {
            fly();
        }

        distance++;
        UpdateDistance();
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
}
