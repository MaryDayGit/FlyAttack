using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{
    [SerializeField]
    GameObject[] buttonUpgrade;
    void Start()
    {
        for (int i = 0; i < buttonUpgrade.Length; i++)
        {
            float indexUp = (i + 2) / 2;
            float price = 5 * GlobalCs.priceIndex * indexUp;
            Debug.Log(indexUp);
            Debug.Log(GlobalCs.priceIndex);
            Debug.Log(price);
            buttonUpgrade[i].GetComponentInChildren<Text>().text = price.ToString();
        }
    }

    public void UpgradeSkiils(int index)
    {
        switch (index)
        {
            case 0:
                UpDmg(index);
                break;
            case 1:
                UpSpeedPlayer(index);
                break;
        }
    }
    void UpDmg(int index)
    {
        float currentPrice = float.Parse(buttonUpgrade[index].GetComponentInChildren<Text>().text);

        if (GlobalCs.money >= currentPrice)
        {
            GlobalCs.damagePlayer += 5;
            GlobalCs.money -= currentPrice;
        }
    }
    void UpSpeedPlayer(int index)
    {
        float currentPrice = float.Parse(buttonUpgrade[index].GetComponentInChildren<Text>().text);
        if (GlobalCs.money >= currentPrice)
        {
            GlobalCs.speedShotPlayer -= 0.1f;
            GlobalCs.money -= currentPrice;
        }
    }
    void UpIdleMoneyIndex(int index)
    {
        float currentPrice = float.Parse(buttonUpgrade[index].GetComponentInChildren<Text>().text);
        if (GlobalCs.money >= currentPrice)
        {
            GlobalCs.idleMoneyIndex += 0.1f;
            GlobalCs.money -= currentPrice;
        }
    }

}
