
using UnityEngine;

public class FallenEnemy : MonoBehaviour
{
    private readonly float speed = 10.0f;

    private void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
    }
}
