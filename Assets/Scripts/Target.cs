using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameManager gameManager;
    private float minSpeed = 12;
    private float maxSpeed =16;
    private float maxTorque = 10;
    private float xRange =  4 ;
    private float ySpawnPos = -1;
    public int pointvalue; 
 
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerRb = GetComponent<Rigidbody>();
        playerRb.AddForce(RandomForce(), ForceMode.Impulse); 
        playerRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
       
    }
    private void OnMouseDown() { 
    Destroy(gameObject);
       
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.updateScore(pointvalue);
    }
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);

    }
    float RandomTorque()
    {
         return Random.Range(-maxTorque, maxTorque); 
    }
   Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
