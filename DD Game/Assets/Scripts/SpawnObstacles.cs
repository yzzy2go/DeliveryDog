using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float maxTimeBetweenSpawn;
    public float minTimeBetweenSpawn;
    private float spawnTime;
    private bool isSpawning = true;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime && isSpawning)
        {
            Spawn();
            spawnTime = Time.time + Random.Range(maxTimeBetweenSpawn, minTimeBetweenSpawn);
        }

        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = maxY;

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}