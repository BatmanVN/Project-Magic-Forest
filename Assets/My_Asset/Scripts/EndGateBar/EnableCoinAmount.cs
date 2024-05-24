using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableCoinAmount : MonoBehaviour
{
    [SerializeField] private Text coinBar;
    [SerializeField] private Text coinAmount;
    [SerializeField] private string keyname;
    [SerializeField] private int amount;
    [SerializeField] private CoinAmount coinCount;

    [ContextMenu("SaveCoin")]

    private void Start()
    {
        amount = coinCount.CountCoin;
        SaveCoin();
    }
    private void SaveCoin()
    {
        PlayerPrefs.SetInt(keyname, amount);
    }
    private void CoinBar()
    {
        coinBar.text = coinAmount.text;
    }
    private void Update()
    {
        CoinBar();
    }
}
