using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignius_SaveData : MonoBehaviour
{
    [SerializeField] private Ignius_Indexs ignius;
    [SerializeField] private Up_Ignius priceCoin;
    [SerializeField] private string healthName;
    [SerializeField] private string powerName;
    [SerializeField] private string speedName;
    [SerializeField] private string starName;
    [SerializeField] private string levelName;
    [SerializeField] private string cointoUp;
    [SerializeField] private string coinUp;

    [ContextMenu("IgniusData")]
    public void IgniusData()
    {
        PlayerPrefs.SetFloat(healthName, ignius.Health);
        PlayerPrefs.SetFloat(powerName, ignius.Power);
        PlayerPrefs.SetFloat(speedName, ignius.Speed);
        PlayerPrefs.SetFloat(starName, ignius.StarDame);
        PlayerPrefs.SetInt(levelName, ignius.Level);
        PlayerPrefs.SetInt(cointoUp, ignius.Number);
        PlayerPrefs.SetInt(coinUp, priceCoin.PriceCoin);
    }
    private void Update()
    {
        IgniusData();
    }
}
