using UnityEngine;
using System;
using UnityEngine.UI;

public class IdleMechanic : MonoBehaviour
{


    public static void OfflineTime()
    {

        if (PlayerPrefs.HasKey("LastSession"))
        {
            GlobalCs.ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            GlobalCs.idleMoney = GlobalCs.ts.Seconds / 60 * GlobalCs.idleMoneyIndex;
            GlobalCs.money += GlobalCs.idleMoney;
            Debug.Log(GlobalCs.ts.Seconds);
            Debug.Log(GlobalCs.idleMoney);
            Debug.Log(GlobalCs.idleMoneyIndex);
        }
        else
        {
            Debug.Log("Not KEy");
        }
    }


}
