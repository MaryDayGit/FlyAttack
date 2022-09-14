using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUpdate : MonoBehaviour
{
    public GameObject levelNextText;
    public GameObject levelPrevText;
    public GameObject moneyText;
    // Start is called before the first frame update
    void Start()
    {
        SaveData.LoadGameInfo();
        float nextlevel = GlobalCs.level + 1;
        levelNextText.GetComponent<Text>().text = nextlevel.ToString();
        levelPrevText.GetComponent<Text>().text = GlobalCs.level.ToString();
        moneyText.GetComponent<Text>().text = GlobalCs.money.ToString();
        OnApplicationQuit();
    }
    void Update()
    {
        float nextlevel = GlobalCs.level + 1;
        levelNextText.GetComponent<Text>().text = nextlevel.ToString();
        levelPrevText.GetComponent<Text>().text = GlobalCs.level.ToString();
        moneyText.GetComponent<Text>().text = GlobalCs.money.ToString();
    }
    void OnApplicationQuit()
    {
        SaveData.SaveGameInfo();
    }
}
