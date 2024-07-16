using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    private Coroutine spawnCoroutine;
    public  List<GameObject> targets;
    
    private float spawnRate = 1;


    public  IEnumerator SpawnTargetCoroutine(int difficulty)
    {
        while (true)
        {
            float spawnTime = spawnRate / difficulty;
            yield return  new WaitForSeconds(spawnTime);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    
    
}
