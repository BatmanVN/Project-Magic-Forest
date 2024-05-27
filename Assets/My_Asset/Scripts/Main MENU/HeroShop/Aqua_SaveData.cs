using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aqua_SaveData : MonoBehaviour
{
    [SerializeField] private Index_Aquana aqua;
    [SerializeField] private Up_Aqua priceCoin;
    [SerializeField] private string healthName;
    [SerializeField] private string powerName;
    [SerializeField] private string speedName;
    [SerializeField] private string starName;
    [SerializeField] private string levelName;
    [SerializeField] private string cointoUp;
    [SerializeField] private string coinUp;

    [ContextMenu("AquaData")]
    private void AquaData()
    {
        PlayerPrefs.SetFloat(healthName, aqua.Health);
        PlayerPrefs.SetFloat(powerName, aqua.Power);
        PlayerPrefs.SetFloat(speedName, aqua.Speed);
        PlayerPrefs.SetFloat(starName, aqua.StarDame);
        PlayerPrefs.SetInt(levelName, aqua.Level);
        PlayerPrefs.SetInt(cointoUp, aqua.Number);
        PlayerPrefs.SetInt(coinUp, priceCoin.PriceCoin);
    }
    private void Update()
    {
        AquaData();
    }
}
