using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDmg : MonoBehaviour
{
    void OnCollisionEnter(Collision myCollision)
    {
        // определение столкновения с двумя разноименными объектами
        if (myCollision.gameObject.CompareTag("Meteor"))
        {
            // Обращаемся к имени объекта с которым столкнулись  
            Debug.Log("Hit the floor");
        }

    }
}

