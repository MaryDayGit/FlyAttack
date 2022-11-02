using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PolyLabs;



public class GameUpdate : MonoBehaviour
{
    public GameObject levelNextText;
    public GameObject levelPrevText;
    public GameObject moneyText;
    public GameObject damagePlayerText;
    string shortScaleNum;
    void Start()
    {
        SaveData.LoadGameInfo();
        shortScaleNum = PolyLabs.ShortScale.ParseFloat(GlobalCs.money);
        moneyText.GetComponent<Text>().text = shortScaleNum;
        float nextLevel = GlobalCs.level + 1;
        damagePlayerText.GetComponent<Text>().text = "УВС: " + GlobalCs.damagePlayer.ToString();
        levelNextText.GetComponent<Text>().text = nextLevel.ToString();
        levelPrevText.GetComponent<Text>().text = GlobalCs.level.ToString();
    }
    void Update()
    {
        shortScaleNum = PolyLabs.ShortScale.ParseFloat(GlobalCs.money);
        moneyText.GetComponent<Text>().text = shortScaleNum;
        float nextLevel = GlobalCs.level + 1;
        damagePlayerText.GetComponent<Text>().text = "УВС: " + GlobalCs.damagePlayer.ToString();
        levelNextText.GetComponent<Text>().text = nextLevel.ToString();
        levelPrevText.GetComponent<Text>().text = GlobalCs.level.ToString();
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        Debug.Log(PlayerPrefs.GetString("LastSession"));
        SaveData.SaveGameInfo();
    }

}
