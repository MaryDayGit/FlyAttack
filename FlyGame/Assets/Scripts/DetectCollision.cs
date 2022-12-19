
using UnityEngine;


public class DetectCollision : MonoBehaviour
{
    float enemyHpLocal = GlobalCs.enemyHp;
    public GameObject projectilePrefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        enemyHpLocal = enemyHpLocal - GlobalCs.damagePlayer;
        
        if (enemyHpLocal <= 0)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            UpLevel.FillLevelProgressBar();
            Destroy(gameObject);
            Destroy(other.gameObject);
            GlobalCs.money += 1 * GlobalCs.moneyIncome;
            GlobalCs.exp = 1;
            enemyHpLocal = GlobalCs.enemyHp;
        }
        else
        {
            Destroy(other.gameObject);
        }

    }

}
