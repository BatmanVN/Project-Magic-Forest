using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{

    [SerializeField] private Text coinText;
    [SerializeField] private Text coinTextBar;
    [SerializeField] private string keyName;
    [SerializeField] private int countCoin;
    [SerializeField] private GameObject coinBar;

    public int CountCoin { get => countCoin; set => countCoin = value; }

    [ContextMenu("GetCoin")]

    private void Start()
    {
        GetCoin();
    }
    private int GetCoin()
    {
        CountCoin = PlayerPrefs.GetInt(keyName,countCoin);
        return CountCoin;
    }
    public void CountCoinAmount()
    {
        CountCoin += 1;
        coinText.text = CountCoin.ToString();
    }
}
