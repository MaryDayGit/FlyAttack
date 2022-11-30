using System;
using UnityEngine;
using UnityEngine.UI;


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
        damagePlayerText.GetComponent<Text>().text = "DMG: " + GlobalCs.damagePlayer.ToString();
        levelNextText.GetComponent<Text>().text = nextLevel.ToString();
        levelPrevText.GetComponent<Text>().text = GlobalCs.level.ToString();
    }
    void Update()
    {
        shortScaleNum = PolyLabs.ShortScale.ParseFloat(GlobalCs.money);
        moneyText.GetComponent<Text>().text = shortScaleNum;
        float nextLevel = GlobalCs.level + 1;
        damagePlayerText.GetComponent<Text>().text = "DMG: " + GlobalCs.damagePlayer.ToString();
        levelNextText.GetComponent<Text>().text = nextLevel.ToString();
        levelPrevText.GetComponent<Text>().text = GlobalCs.level.ToString();
    }
    void OnApplicationPause()
    {
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        SaveData.SaveGameInfo();
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        SaveData.SaveGameInfo();
    }

}
