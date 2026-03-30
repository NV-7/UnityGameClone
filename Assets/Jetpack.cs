using UnityEngine;
using UnityEngine.InputSystem;

public class Jetpack : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Rigidbody2D rb;
    public float speed;
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
    }


    void fly()
    {
        Vector2 upForce = new Vector2(0, 10);
        rb.AddForce(upForce* speed);
    }
}
