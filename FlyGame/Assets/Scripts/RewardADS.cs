using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class RewardADS : MonoBehaviour
{
    private string RewardedUnitId = "ca-app-pub-3940256099942544/5224354917";
    private RewardedAd rewardedAd;
    private void OnEnable()
    {
        rewardedAd = new RewardedAd(RewardedUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        float coins = GlobalCs.money;
        coins += 150;
        GlobalCs.money += coins;
    }
    public void ShowAd()
    {
        if (rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
        }
    }
}
