using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;


[System.Serializable]
public class SaveData
{
    private float savedLevel;
    private float savedMoney;
    private float savedDamage;
    private float savedSpeedShootPlayer;
    private float idleIndexSaved;
    private float moneyIncome;
    private bool startGame;
    private float indexPriceDmg;
    private float indexPriceSpeed;
    private float indexPriceIncome;
    private float indexPriceIdle;
    private bool started;
    public static void SaveGameInfo()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream saveFile = File.Create(Application.persistentDataPath + "/MySaveData.dat");
        SaveData data = new SaveData();
        data.savedLevel = GlobalCs.level;
        data.savedMoney = GlobalCs.money;
        data.savedDamage = GlobalCs.damagePlayer;
        data.indexPriceDmg = GlobalCs.indexPriceDmg;
        data.indexPriceSpeed = GlobalCs.indexPriceSpeed;
        data.indexPriceIncome = GlobalCs.indexPriceIncome;
        data.indexPriceIdle = GlobalCs.indexPriceIdle;
        data.idleIndexSaved = GlobalCs.idleMoneyIndex;
        data.savedSpeedShootPlayer = GlobalCs.speedShotPlayer;
        data.moneyIncome = GlobalCs.moneyIncome;
        data.startGame = GlobalCs.startGame;
        data.started = GlobalCs.started;
        bf.Serialize(saveFile, data);
        saveFile.Close();
        Debug.Log("Game Saved");

    }
    public static void LoadGameInfo()
    {
        if (File.Exists(Application.persistentDataPath + "/MySaveData.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream saveFile = File.Open(Application.persistentDataPath + "/MySaveData.dat", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(saveFile);
            saveFile.Close();
            GlobalCs.level = data.savedLevel;
            GlobalCs.money = data.savedMoney;
            GlobalCs.damagePlayer = data.savedDamage;
            GlobalCs.indexPriceDmg = data.indexPriceDmg;
            GlobalCs.indexPriceSpeed = data.indexPriceSpeed;
            GlobalCs.indexPriceIncome = data.indexPriceIncome;
            GlobalCs.indexPriceIdle = data.indexPriceIdle;
            GlobalCs.idleMoneyIndex = data.idleIndexSaved;
            GlobalCs.speedShotPlayer = data.savedSpeedShootPlayer;
            GlobalCs.moneyIncome = data.moneyIncome;
            GlobalCs.moneyIncome = data.moneyIncome;
            GlobalCs.startGame = data.startGame;
            GlobalCs.started = data.started;
            IdleMechanic.OfflineTime();
            Debug.Log("Game load");
        }
    }
    public static void ResetData()
    {
        if (File.Exists(Application.persistentDataPath + "/MySaveData.dat"))
        {
            File.Delete(Application.persistentDataPath + "/MySaveData.dat");
            GlobalCs.damagePlayer = 1;
            GlobalCs.level = 1;
            GlobalCs.money = 1;
            GlobalCs.enemyHp = 1;
            GlobalCs.indexPriceDmg = 1;
            GlobalCs.indexPriceIdle = 1;
            GlobalCs.indexPriceIncome = 1;
            GlobalCs.indexPriceSpeed = 1;
            GlobalCs.speedShotPlayer = 0.5f;
            GlobalCs.idleMoneyIndex = 1f;
            GlobalCs.moneyIncome = 1f;
            GlobalCs.money = 1f;
            GlobalCs.startGame = true;
            GlobalCs.started = false;
            Debug.Log("Data reset ok");
        }
    }
}
