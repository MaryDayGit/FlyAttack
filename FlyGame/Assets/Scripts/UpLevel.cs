
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

    public static void FillLevelProgressBar()
    {
        levelProgress.value += GlobalCs.exp;
        if (levelProgress.value == levelProgress.maxValue)
        {
            levelProgress.value = 0;
            levelProgress.maxValue += 10;
            GlobalCs.level += 1;

        }
    }
}
