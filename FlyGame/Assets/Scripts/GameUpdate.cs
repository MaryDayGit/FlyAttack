using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameUpdate : MonoBehaviour
{
    public GameObject levelNextText;
    public GameObject levelPrevText;
    public GameObject moneyText;
    public GameObject damagePlayerText;
    void Start()
    {
        SaveData.LoadGameInfo();
        IdleMechanic.OfflineTime();
        float nextlevel = GlobalCs.level + 1;
        damagePlayerText.GetComponent<Text>().text = "УВС: " + GlobalCs.damagePlayer.ToString();
        levelNextText.GetComponent<Text>().text = nextlevel.ToString();
        levelPrevText.GetComponent<Text>().text = GlobalCs.level.ToString();
        moneyText.GetComponent<Text>().text = GlobalCs.money.ToString();
    }
    void Update()
    {
        float nextlevel = GlobalCs.level + 1;
        damagePlayerText.GetComponent<Text>().text = "УВС: " + GlobalCs.damagePlayer.ToString();
        levelNextText.GetComponent<Text>().text = nextlevel.ToString();
        levelPrevText.GetComponent<Text>().text = GlobalCs.level.ToString();
        moneyText.GetComponent<Text>().text = GlobalCs.money.ToString();

    }
#if UNITY_ANDROID && !UNITY_EDITOR
    void OnApplicationQuit()
    {
        Debug.Log("Сохранение после выхода");
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        SaveData.SaveGameInfo();

    }
#else
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        }
    }
#endif
}
