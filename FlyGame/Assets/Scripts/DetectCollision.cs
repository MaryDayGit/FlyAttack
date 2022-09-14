using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {


        GlobalCs.enemyHp = GlobalCs.enemyHp - GlobalCs.damagePlayer;
        if (GlobalCs.enemyHp <= 0)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GlobalCs.money += 1;
            GlobalCs.exp += 1;

        }

    }
}
