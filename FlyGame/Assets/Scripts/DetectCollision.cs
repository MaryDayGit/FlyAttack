using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    float enemyHpLocal = GlobalCs.enemyHp;
    public GameObject projectilePrefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        enemyHpLocal = enemyHpLocal - GlobalCs.damagePlayer;
        //TODO УДАЛЯТЬ ПРЕФАБ РАКЕТЫ
        if (enemyHpLocal <= 0)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            UpLevel.fillLevelProgressBar();
            Destroy(gameObject);
            Destroy(other.gameObject);
            GlobalCs.money += 1 * GlobalCs.moneyIncome;
            GlobalCs.exp = 1;
            enemyHpLocal = GlobalCs.enemyHp;
        }

    }

}
