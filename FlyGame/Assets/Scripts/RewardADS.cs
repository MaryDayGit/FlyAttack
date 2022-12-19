using System.Collections;
using UnityEngine;
using GoogleMobileAds.Api;


public class RewardADS : MonoBehaviour
{
    private string RewardedUnitId = "ca-app-pub-5148027685452292/5807661229";
    private RewardedAd rewardedAd;
    [SerializeField] float _sec;
    [SerializeField] GameObject _objectToActive;
    private void OnEnable()
    {
        CreateAndLoadAD();
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
            _sec = 60;
            _objectToActive.gameObject.SetActive(false);
            StartCoroutine(ActivationRoutine());
        }
    }
    private IEnumerator ActivationRoutine()
    {
        yield return new WaitForSeconds(_sec);
        CreateAndLoadAD();
        _objectToActive.gameObject.SetActive(true);
        _sec = 0;
    }
    private void CreateAndLoadAD()
    {
        rewardedAd = new RewardedAd(RewardedUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }
}
