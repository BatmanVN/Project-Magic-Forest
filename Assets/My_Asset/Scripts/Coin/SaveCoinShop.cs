using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveCoinShop : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private int saveCoin;

    [ContextMenu("SaveCoin")]
    public void SaveCoin()
    {
        PlayerPrefs.SetInt(keyName, saveCoin);
    }
    private void Start()
    {
        SaveCoin();
    }
}
