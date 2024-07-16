using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDestroyer : MonoBehaviour
{
    [SerializeField] private int pointValue;

    [SerializeField] private ParticleSystem explosionParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        //invokes the ObjectDestroyed event in game manager
        EventManager.TriggerOnObjectDestroyed(pointValue);

        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.)
        //Destroy(gameObject);
    }
}
