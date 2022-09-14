using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpLevel : MonoBehaviour
{



    public static void fillLevelProgressBar(Slider levelProgressBar)
    {
        Debug.Log(levelProgressBar);
        levelProgressBar.value += GlobalCs.exp;
    }
}
