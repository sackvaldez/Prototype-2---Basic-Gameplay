using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    private float spawnPosZ = 20;
    private float spawnRangeX = 20;
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.S)) // NO IN USE ANYMORE
        // {
        //     SpawnRandomAnimal();
        // }
    }
    // Specific Random Spawning Function using Spawn Variables
    void SpawnRandomAnimal()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // We create an Animal from the animalIndex(which is random) in a random spawn position using the same rotation
        Instantiate(animalPrefabs[animalIndex], spawnPosition,
        animalPrefabs[animalIndex].transform.rotation);
    }
}
