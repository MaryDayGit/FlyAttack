using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{
    [SerializeField]
    GameObject[] buttonUpgrade;
    private float indexPrice = 1.08f;
    string shortScaleNum;
    void Start()
    {
        if (GlobalCs.startGame == false) { UpdateAllPrice(); }
        else
        {
            for (int i = 0; i < buttonUpgrade.Length; i++)
            {
                UpdatePrice(i);
            }
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
            case 2:
                UpIdleMoneyIndex(index);
                break;
            case 3:
                UpMoneyIncome(index);
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
            GlobalCs.indexPriceDmg += 0.5f;
            UpdatePrice(index);
        }
    }
    void UpSpeedPlayer(int index)
    {

        float currentPrice = float.Parse(buttonUpgrade[index].GetComponentInChildren<Text>().text);
        if (GlobalCs.money >= currentPrice)
        {
            GlobalCs.speedShotPlayer -= 0.1f;
            GlobalCs.money -= currentPrice;
            GlobalCs.indexPriceSpeed += 0.7f;
            UpdatePrice(index);
        }
    }
    void UpIdleMoneyIndex(int index)
    {

        float currentPrice = float.Parse(buttonUpgrade[index].GetComponentInChildren<Text>().text);
        if (GlobalCs.money >= currentPrice)
        {
            GlobalCs.idleMoneyIndex += 0.1f;
            GlobalCs.money -= currentPrice;
            GlobalCs.indexPriceIdle += 1f;
            UpdatePrice(index);
        }
    }
    void UpMoneyIncome(int index)
    {

        float currentPrice = float.Parse(buttonUpgrade[index].GetComponentInChildren<Text>().text);
        if (GlobalCs.money >= currentPrice)
        {
            GlobalCs.money += 0.1f;
            GlobalCs.money -= currentPrice;
            GlobalCs.indexPriceIncome += 1f;
            UpdatePrice(index);

        }
    }
    private void UpdateAllPrice()
    {
        for (int i = 0; i < buttonUpgrade.Length; i++)
        {
            float price = 0;
            switch (i)
            {
                case 0:
                    price = 25;
                    break;
                case 1:
                    price = 50;
                    break;
                case 2:
                    price = 100;
                    break;
                case 3:
                    price = 150;
                    break;

            }
            shortScaleNum = PolyLabs.ShortScale.ParseFloat(price);
            buttonUpgrade[i].GetComponentInChildren<Text>().text = shortScaleNum.ToString();
            GlobalCs.startGame = true;
        }
    }
    private void UpdatePrice(int i)
    {
        float baseCost = 0;
        float index = 0;
        switch (i)
        {
            case 0:
                baseCost = 25;
                index = GlobalCs.indexPriceDmg;
                break;
            case 1:
                baseCost = 50;
                index = GlobalCs.indexPriceSpeed;
                break;
            case 2:
                baseCost = 100;
                index = GlobalCs.indexPriceIdle;
                break;
            case 3:
                baseCost = 150;
                index = GlobalCs.indexPriceIncome;
                break;

        }
        float price = baseCost * Mathf.Pow(indexPrice, index);
        shortScaleNum = PolyLabs.ShortScale.ParseFloat(price);
        buttonUpgrade[i].GetComponentInChildren<Text>().text = shortScaleNum.ToString();
    }
}
