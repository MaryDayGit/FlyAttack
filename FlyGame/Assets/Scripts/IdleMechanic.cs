using UnityEngine;
using System;


public class IdleMechanic : MonoBehaviour
{


    public static void OfflineTime()
    {
        if (PlayerPrefs.HasKey("LastSession"))
        {
            GlobalCs.ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            if (GlobalCs.ts.Minutes < 120)
            {
                GlobalCs.idleMoney = GlobalCs.ts.Minutes * GlobalCs.idleMoneyIndex;
                GlobalCs.money += GlobalCs.idleMoney;
            }
            else
            {
                GlobalCs.idleMoney = 120 * GlobalCs.idleMoneyIndex;
                GlobalCs.money += GlobalCs.idleMoney;
            }
        }
        else
        {
            Debug.Log("Not KEy");
        }
    }


}
