using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignius_SaveData : MonoBehaviour
{
    [SerializeField] private Ignius_Indexs ignius;
    [SerializeField] private string keyName;
    [SerializeField] private float healthSave;
    [SerializeField] private float powerSave;
    [SerializeField] private float speedSave;
    [SerializeField] private float starSave;

    protected void IgniusData()
    {
        PlayerPrefs.SetString(keyName, JsonUtility.ToJson(healthSave));
        PlayerPrefs.SetString(keyName, JsonUtility.ToJson(powerSave));
        PlayerPrefs.SetString(keyName, JsonUtility.ToJson(speedSave));
        PlayerPrefs.SetString(keyName, JsonUtility.ToJson(starSave));
    }
    private void SaveData()
    {
        healthSave = ignius.Health;
        powerSave = ignius.Power;
        speedSave = ignius.Speed;
        starSave = ignius.StarDame;
    }
    private void Update()
    {
        SaveData();
    }
    //private void Start()
    //{
    //    IgniusData();
    //}
}
