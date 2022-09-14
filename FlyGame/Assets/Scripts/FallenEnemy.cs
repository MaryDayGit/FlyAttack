using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenEnemy : MonoBehaviour
{
    private float speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
    }
}
