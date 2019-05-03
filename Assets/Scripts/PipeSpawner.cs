using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float spawnTime = 1.5f; 
    [SerializeField] float startingX = 12f; 
    [SerializeField] float minY = -2.5f; 
    [SerializeField] float maxY = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }
    void SpawnPipe() 
    { 
        GameObject.Instantiate( 
            pipe, new Vector3(startingX, Random.Range(minY, maxY), 0), Quaternion.identity); 
            Invoke("SpawnPipe", spawnTime); 
    }
}
