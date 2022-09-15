using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float width = GlobalCs.screenWidth / 15;
        transform.localScale = Vector3.one * width / 200;
    }
}
