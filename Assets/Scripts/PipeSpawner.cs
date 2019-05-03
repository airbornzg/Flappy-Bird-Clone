using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float spawnTime; 
    [SerializeField] float startingX; 
    [SerializeField] float minY; 
    [SerializeField] float maxY;

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
