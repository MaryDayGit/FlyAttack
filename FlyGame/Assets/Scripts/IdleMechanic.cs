using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IdleMechanic : MonoBehaviour
{
    public static void OfflineTime()
    {
        TimeSpan ts;
        if (PlayerPrefs.HasKey("LastSession"))
        {
            ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            float idleMoney = (ts.Seconds / 60) * GlobalCs.idleMoneyIndex;
            GlobalCs.money += idleMoney;
            Debug.Log(idleMoney);
        }
        else
        {
            Debug.Log("Not KEy");
        }
    }
}
