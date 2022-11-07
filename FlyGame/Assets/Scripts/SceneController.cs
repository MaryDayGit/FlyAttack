using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SaveData.ResetData();
        SceneManager.LoadScene(1);
        Debug.Log(GlobalCs.damagePlayer);
        Debug.Log(GlobalCs.enemyHp);
        Debug.Log(GlobalCs.speedShotPlayer);
        Debug.Log(GlobalCs.money);

    }
}
