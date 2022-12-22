using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipChangeSprite : MonoBehaviour
{
    [SerializeField] Sprite[] picShip;
    [SerializeField] Image img;
    [SerializeField] GameObject prevButt;
    [SerializeField] GameObject nextButt;
    [SerializeField] Button butButt;
    public TextMeshProUGUI text;
    public TextMeshProUGUI textButt;
    int indexSave = 0;
    public void NextShipChangeSprite()
    {
        if (indexSave < 5)
        {
            img.sprite = picShip[indexSave + 1];
            indexSave += 1;
        }
    }
    public void Update()
    {
        img.sprite = picShip[indexSave];
        SwitchPriceShipText();
        if (indexSave == 5)
        {
            nextButt.SetActive(false);
        }
        else { nextButt.SetActive(true); }
        if (indexSave == 0)
        {
            prevButt.SetActive(false);
        }
        else { prevButt.SetActive(true); }
    }
    private void SwitchPriceShipText()
    {
        switch (indexSave)
        {
            case 0:
                text.text = "+50 DMG \n" + " х2 Gold Income";
                textButt.text = "5000";
                break;
            case 1:
                text.text = " + 100 DMG \n" + " х3 Gold Income";
                textButt.text = "10000";
                break;
            case 2:
                text.text = " + 200 DMG \n" + " х4 Gold Income";
                textButt.text = "15000";
                break;
            case 3:
                text.text = " + 300 DMG \n" + " х5 Gold Income";
                textButt.text = "20000";
                break;
            case 4:
                text.text = " + 400 DMG \n" + " х6 Gold Income";
                textButt.text = "25000";
                break;
            case 5:
                text.text = " + 500 DMG \n" + " х7 Gold Income";
                textButt.text = "50000";
                break;

        }
    }
    public void PrevShipChangeSprite()
    {
        if (indexSave <= 0) { img.sprite = picShip[0]; } else { img.sprite = picShip[indexSave - 1]; indexSave -= 1; }
    }
}
