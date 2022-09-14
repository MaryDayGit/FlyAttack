using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;
    public GameObject projectilePrefab;
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
        if (Input.GetKeyDown(KeyCode.Space)) { Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); }
    }

}
