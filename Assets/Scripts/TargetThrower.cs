using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetThrower : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 11;
    private float maxSpeed = 14;
    private float minTorque = -10;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -2;
    
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        
        targetRb.AddForce(Vector3.up* RandomForce(),ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(),ForceMode.Impulse);
        RandomSpawnGenerator();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float RandomForce()
    {
        return Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(minTorque, maxTorque);
    }

    void RandomSpawnGenerator()
    {
        transform.position = new Vector3(Random.Range(-xRange, xRange), ySpawnPos,0);
    }
}