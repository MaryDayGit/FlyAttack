using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;


[System.Serializable]
public class SaveData
{
    public float savedLevel;
    public float savedMoney;
    public static void SaveGameInfo()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream saveFile = File.Create(Application.persistentDataPath + "/MySaveData.dat");
        SaveData data = new SaveData();
        data.savedLevel = GlobalCs.level;
        data.savedMoney = GlobalCs.money;
        bf.Serialize(saveFile, data);
        saveFile.Close();
        Debug.Log("Game Saved");
        Debug.Log("Save money " + GlobalCs.money);
        Debug.Log("Save level " + GlobalCs.level);
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
            Debug.Log("Game load");
            Debug.Log("Load money " + GlobalCs.money);
            Debug.Log("Loadlevel " + GlobalCs.level);
        }
    }
}
