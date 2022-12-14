
using UnityEngine;


public class SpawnController : MonoBehaviour
{
    private const float V = 1.5f;
    public GameObject[] cubeEnemy;
    private float startDelay = 3;
    private float spawnInterval = 0.7f;
    void Start()
    {
        InvokeRepeating("SpawnRandomCube", startDelay, spawnInterval);
    }
    void SpawnRandomCube()
    {
        SetHpEnemy();
        int enemyIndex = Random.Range(0, cubeEnemy.Length);
        Vector3 spawnPos = new(Random.Range(-GlobalCs.screenWidth / 210, GlobalCs.screenWidth / 210), GlobalCs.screenHeigt / 150, 0);
        Instantiate(cubeEnemy[enemyIndex], spawnPos, cubeEnemy[enemyIndex].transform.rotation);
    }
    void SetHpEnemy()
    {
        GlobalCs.enemyHp = GlobalCs.level * V / 1.2f;
    }
}
