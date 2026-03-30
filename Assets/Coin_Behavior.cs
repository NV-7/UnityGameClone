using Unity.VisualScripting;
using UnityEngine;

public class Coin_Behavior : MonoBehaviour
{
    public Vector3 deltaPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void FixedUpdate()
    {
        Vector3 currentPos = this.transform.position;
        deltaPos = new Vector3(-0.3f, 0, 0);
        currentPos = currentPos + deltaPos;
        transform.position = currentPos;

        if(currentPos.x > -20f)
        {
            Terminate();
        }
    }

    private void Terminate()
    {
        Destroy(this);
    }
}
