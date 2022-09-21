using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }

}
