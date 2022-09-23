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

    }



}
