using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveGame : MonoBehaviour
{
    public void SaveGameInfo()
    {
        SaveData.SaveGameInfo();
    }
    public void LoadGameInfo()
    {
        SaveData.LoadGameInfo();
    }
    public void ResetDataInof()
    {
        SaveData.ResetData();
    }
}
