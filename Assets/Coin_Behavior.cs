using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin_Behavior : MonoBehaviour
{
    public Vector3 deltaPos;
    public float speed = 0.1f;
    private string tag;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tag = this.transform.tag;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void FixedUpdate()
    {
        Vector3 currentPos = this.transform.position;
        deltaPos = new Vector3(-speed, 0, 0);
        currentPos = currentPos + deltaPos;
        transform.position = currentPos;

        if(transform.position.x < -10f)
        {
            Terminate();
        }

    }

    private void Terminate()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(tag.Equals("Missile") && collision.tag.Equals("Player"))
        {
            
        }
        
        
    }
}
