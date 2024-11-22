using UnityEngine;

public class PipeMoveSc : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

public  float moveSpeed  = 5;
public float deadZone = -70;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed)* Time.deltaTime;


        if(transform.position.x < deadZone){
            Destroy(gameObject);
        }
    }
}
