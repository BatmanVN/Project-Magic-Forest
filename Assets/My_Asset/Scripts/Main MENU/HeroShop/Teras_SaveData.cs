using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teras_SaveData : MonoBehaviour
{
    [SerializeField] private Index_Teras teras;
    [SerializeField] private string healthName;
    [SerializeField] private string powerName;
    [SerializeField] private string speedName;
    [SerializeField] private string starName;
    [SerializeField] private string levelName;

    [ContextMenu("TerasData")]
    private void TerasData()
    {
        PlayerPrefs.SetFloat(healthName, teras.Health);
        PlayerPrefs.SetFloat(powerName, teras.Power);
        PlayerPrefs.SetFloat(speedName, teras.Speed);
        PlayerPrefs.SetFloat(starName, teras.StarDame);
        PlayerPrefs.SetInt(levelName, teras.Level);
    }
    private void Start()
    {
        TerasData();
    }
}
