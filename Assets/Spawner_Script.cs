using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject coin;
    private float initialTime = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject c = null;
        initialTime += Time.deltaTime;
        if (initialTime > 2f)
        {
            c = spawn_Coin();
            initialTime = 0;
        }

        
    }

    GameObject spawn_Coin()
    {

        return Instantiate(coin, new Vector2(12f, 0f), Quaternion.identity);

    }



}
