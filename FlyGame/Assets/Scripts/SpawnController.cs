using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SpawnController : MonoBehaviour
{
    private const float V = 1.2f;
    public GameObject[] cubeEnemy;
    private float startDelay = 2;
    private float spawnInterval = 0.7f;
    void Start()
    {
        InvokeRepeating("SpawnRandomCube", startDelay, spawnInterval);
    }
    void SpawnRandomCube()
    {
        SetHpEnemy();

        int enemyIndex = Random.Range(0, cubeEnemy.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-GlobalCs.screenWidth / 210, GlobalCs.screenWidth / 210), GlobalCs.screenHeigt / 150, 0);
        Instantiate(cubeEnemy[enemyIndex], spawnPos, cubeEnemy[enemyIndex].transform.rotation);

    }
    void SetHpEnemy()
    {
        GlobalCs.enemyHp = GlobalCs.level * V;
    }
}
