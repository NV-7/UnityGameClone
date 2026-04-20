using UnityEngine;

public class speed : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float bgSpeed = 5f;
    public GameObject background;
    public float originalSpeed;
    public float maxTime = 8f;
    public float time = 0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if(time >= maxTime)
        {
            background.GetComponent<background>().speed = originalSpeed;
            time = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
           originalSpeed = background.GetComponent<background>().speed;
           background.GetComponent<background>().speed = bgSpeed;
        }
    }
}
