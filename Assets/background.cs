using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject coin;
    public float speed = 5f;
    private float outOfBounds = -20f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MoveBackground();
    }


    void MoveBackground()
    {
        Transform bkg = null;
        int childCount = this.transform.childCount;
        for(int i = 0; i < childCount; i++)
        {
            bkg = this.transform.GetChild(i);
            Vector3 newPos = new Vector3(speed * Time.fixedDeltaTime, 0, 0);
            bkg.position = bkg.position - newPos;

            Debug.Log(i + " " + bkg.position.x);
            if (bkg.position.x < outOfBounds)
            {
                bkg.position = new Vector3(17,0,bkg.position.z);
            }
            

        }
    }

  
}
