using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpLevel : MonoBehaviour
{
    [SerializeField]
    private Slider levelProgressBar;
    private static Slider levelProgress;
    private void Start()
    {
        levelProgress = levelProgressBar;
    }

    public static void fillLevelProgressBar()
    {
        levelProgress.value += GlobalCs.exp;
        if (levelProgress.value == levelProgress.maxValue)
        {
            levelProgress.value = 0;
            GlobalCs.level += 1;

        }
    }
}
