using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject coin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject c = null;
        float initial_Time = Time.deltaTime;
        if(initial_Time > 2f)
        {
             c = spawn_Coin();
             initial_Time = 0;
        }

        if(c != null)
        {
            Vector3 currentPos = c.transform.position;
            Vector3 deltaPos = new Vector3(1, 1, 1);
            currentPos = currentPos + deltaPos;
        }
    }

    GameObject spawn_Coin() {

        return Instantiate(coin, new Vector2(15f, 0f), Quaternion.identity);

    }

    

}
