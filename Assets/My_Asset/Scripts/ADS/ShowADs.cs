using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowADs : MonoBehaviour
{
    [SerializeField] private RewardedAdsButton adsButton;

    public void ShowADS()
    {
        adsButton.ShowAd();
    }
}
