
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    private Transform back_Transform;
    private float back_Size;
    private float back_poz;
    private readonly float speed = 1;
    void Start()
    {
        back_Transform = GetComponent<Transform>();
        back_Size = GetComponent<SpriteRenderer>().bounds.size.y;
    }
    private void Update()
    {
        Move();
    }

    public void Move()
    {
        back_poz += speed * Time.deltaTime;
        back_poz = Mathf.Repeat(back_poz, back_Size);
        back_Transform.position = new Vector3(0, back_poz, 0);
    }


}
