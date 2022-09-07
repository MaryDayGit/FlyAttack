using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject cubeEnemy;
    private float spawnRangeX = -2;
    private float startDelay = 2;
    private float spawnInterval = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCube", startDelay, spawnInterval);
    }
    void SpawnRandomCube()
    {
        for (int i = 0; i < 7; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, 2), 10, 0);
            Instantiate(cubeEnemy, spawnPos, cubeEnemy.transform.rotation);
        }
    }
}
