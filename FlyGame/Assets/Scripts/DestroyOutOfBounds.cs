
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -GlobalCs.screenHeigt / 50)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > GlobalCs.screenHeigt / 50)
        {
            Destroy(gameObject);
        }
    }
}
