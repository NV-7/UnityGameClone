using System;
using UnityEngine;

public class speed : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float bgSpeed = 10f;
    public GameObject background;
    public float originalSpeed;
    public float maxTime = 8f;
    public float time = 0f;
    private Jetpack player;
    private Boolean speeding = false;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Jetpack>();
        background = GameObject.FindWithTag("BG");
    }

    // Update is called once per frame
    void Update()
    {
        if (speeding)
        {
         time = time + Time.deltaTime;
        if(time >= maxTime)
        {
            background.GetComponent<background>().speed = originalSpeed;
            player.speeding = false;
            Destroy(gameObject);
            time = 0f;
        }

        }
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            speeding = true;
           originalSpeed = background.GetComponent<background>().speed;
           background.GetComponent<background>().speed = bgSpeed;
            GetComponent<SpriteRenderer>().enabled = false;
            player.speeding = true;
           
        }
    }
    void FixedUpdate()
    {
        if (speeding)
        {
        Vector3 newPos = new Vector3(bgSpeed * Time.fixedDeltaTime, 0, 0);
        background.transform.position -= newPos; 
        }
    }
}
