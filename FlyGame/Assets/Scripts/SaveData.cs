using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;


[System.Serializable]
public class SaveData
{
    public float savedLevel;
    public float savedMoney;
    public float savedDamage;
    public float priceIndex;
    public float savedSpeedShootPlayer;
    public static void SaveGameInfo()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream saveFile = File.Create(Application.persistentDataPath + "/MySaveData.dat");
        SaveData data = new SaveData();
        data.savedLevel = GlobalCs.level;
        data.savedMoney = GlobalCs.money;
        data.savedDamage = GlobalCs.damagePlayer;
        data.priceIndex = GlobalCs.priceIndex;
        data.savedSpeedShootPlayer = GlobalCs.speedShotPlayer;
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
            GlobalCs.priceIndex = data.priceIndex;
            GlobalCs.speedShotPlayer = data.savedSpeedShootPlayer;
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
            GlobalCs.priceIndex = 2;
            GlobalCs.speedShotPlayer = 1.5f;
            Debug.Log("Data reset ok");
        }
    }
}
