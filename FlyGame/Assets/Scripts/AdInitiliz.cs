
using UnityEngine;
using GoogleMobileAds.Api;

public class AdInitiliz : MonoBehaviour
{
    private void Awake()
    {
        MobileAds.Initialize(initStatus => { });
    }
}
