using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = new Vector2(-0.5f, 0);
        transform.position = -1.5f* newPos;
    }
}
