using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidSpawner : MonoBehaviour
{

    // Sets variables to acid and spawn objects
    public GameObject acid;
    public Transform spawn;

    // Sets variables to spawn interval
    public float spawnRate;
    public float nextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Sets random interval to spawnrate
        spawnRate = Random.Range(0.2f, 2f);

        // Call Spawn method
        Spawn();
        
    }

    // Creates Spawn Method
    void Spawn(){

        // Compare gametime with next spawn
        if(Time.time > nextSpawn){

            // Spawn acid at spawn position
            Instantiate(acid, spawn.position, spawn.rotation);

            // Update next spawn
            nextSpawn = Time.time + spawnRate;

        }

    }

}
