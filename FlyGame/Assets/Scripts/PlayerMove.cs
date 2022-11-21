using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject projectilePrefab;

    private float timestamp;
    private void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            if (Time.time >= timestamp)
            {

                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                timestamp = Time.time + GlobalCs.speedShotPlayer;
            }
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
