using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Pipe;
    public float spawnRate = 2;
    private float Timer = 0;
    public float heightOffSet = 10;
    void Start()
    {
        spamPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < spawnRate){
            Timer += Time.deltaTime;
        }

        else{
        spamPipe();
        Timer = 0; 
         //Instantiate(Pipe , new Vector3(transform.position.x , transform.position.y,0), transform.rotation);
        }
    }

    void spamPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float heighestPoint = transform.position.y + heightOffSet;

        Instantiate(Pipe , new Vector3(transform.position.x , Random.Range(lowestPoint , heighestPoint),0), transform.rotation);
    }
}
