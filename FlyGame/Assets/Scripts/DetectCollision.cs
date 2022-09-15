using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    float enemyHpLocal = GlobalCs.enemyHp;
    // public GameObject missllePrefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //missllePrefab = GameObject.FindGameObjectWithTag("Missille");
        enemyHpLocal = enemyHpLocal - GlobalCs.damagePlayer;
        // Destroy(missllePrefab);
        if (enemyHpLocal <= 0)
        {
            UpLevel.fillLevelProgressBar();
            Destroy(gameObject);
            Destroy(other.gameObject);
            GlobalCs.money += 1;
            GlobalCs.exp = 1;
            enemyHpLocal = GlobalCs.enemyHp;
        }

    }

}
