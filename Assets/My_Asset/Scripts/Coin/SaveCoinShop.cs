using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveCoinShop : MonoBehaviour
{
    [SerializeField] private string keyName;
    //[SerializeField] private int saveCoin;
    [SerializeField] private CoinToUp coinSave;
    
    [ContextMenu("SaveCoin")]
    public void SaveCoin()
    {
        //PlayerPrefs.SetInt(keyName, coinSave.CoinUp);
    }
    private void Start()
    {
        SaveCoin();
    }
}
