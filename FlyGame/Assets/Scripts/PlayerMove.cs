using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float timeBetweenShots = 0.01f;
    private float timestamp;
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            if (Time.time >= timestamp)
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                timestamp = Time.time + timeBetweenShots;
                Debug.Log(Time.time);
                Debug.Log(timestamp);
            }
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
