using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 10.0f;

    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
    }
}
