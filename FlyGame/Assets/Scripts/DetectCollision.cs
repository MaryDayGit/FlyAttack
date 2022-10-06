using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    float enemyHpLocal = GlobalCs.enemyHp;
    private void OnTriggerEnter2D(Collider2D other)
    {
        enemyHpLocal = enemyHpLocal - GlobalCs.damagePlayer;
        if (enemyHpLocal <= 0)
        {
            UpLevel.fillLevelProgressBar();
            Destroy(gameObject);
            Destroy(other.gameObject);
            GlobalCs.money += 1 * GlobalCs.moneyIncome;
            GlobalCs.exp = 1;
            enemyHpLocal = GlobalCs.enemyHp;
        }

    }

}
