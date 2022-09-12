using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    private void Move()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float newPosX = transform.position.x + deltaX;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var newPosY = transform.position.y + deltaY;
        transform.position = new Vector2(newPosX, newPosY);

    }

}
