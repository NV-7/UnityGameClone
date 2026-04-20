using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject coin;
    public GameObject[] objects;
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
            c = spawnObject();
            initialTime = 0;
        }

        
    }

    
    GameObject spawnObject()
    {
        int index;
        float randomNum = Random.Range(0f, 100f);
        if (randomNum < 10f)
        {
            index = objects.Length - 1;
        }
        else
        {
            index = Random.Range(0, objects.Length - 1);
        }

        Vector2 spawnLocation = new Vector2(this.transform.position.x, Random.Range(-5f, 5f));
        return Instantiate(objects[index], spawnLocation, Quaternion.identity);

    }

}
