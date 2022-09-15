using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOutOfBounds : MonoBehaviour
{
    private float padding = 0.5f;

    // Update is called once per frame
    void Update()
    {
        ClampPlayer();
    }
    void ClampPlayer()
    {
        Vector3 position = transform.position;
        float distance = transform.position.z - Camera.main.transform.position.z;
        float leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).x + padding;
        float rigthBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance)).x - padding;
        float topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance)).y + padding;
        float bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distance)).y - padding;
        position.x = Mathf.Clamp(position.x, leftBorder, rigthBorder);
        position.y = Mathf.Clamp(position.y, topBorder, bottomBorder);
        transform.position = position;
    }
}
