using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HandleControl : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    [SerializeField] GameObject playerPrefab;
    float moveSpeed = 50f;
    [SerializeField] GameObject projectilePrefab;

    public void OnBeginDrag(PointerEventData eventData)

    {

    }
    void Update()
    {

    }


    public void OnDrag(PointerEventData eventData)

    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))

        {

            if (eventData.delta.x > 0)
            {
                playerPrefab.transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
            }

            else
            {

                playerPrefab.transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);
            }

        }

        else

        {

            if (eventData.delta.y > 0)
            {

                playerPrefab.transform.Translate(new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime);
            }

            else
            {

                playerPrefab.transform.Translate(new Vector3(0, -1, 0) * moveSpeed * Time.deltaTime);
            }

        }
    }
}
