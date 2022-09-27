using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IdleMechanic : MonoBehaviour
{
    public static void OfflineTime()
    {
        TimeSpan ts;
        if (PlayerPrefs.HasKey("LatSession"))
        {
            ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LasSession"));
            GlobalCs.money += (ts.Seconds / 60) * GlobalCs.idleMoneyIndex;
        }
    }
}
