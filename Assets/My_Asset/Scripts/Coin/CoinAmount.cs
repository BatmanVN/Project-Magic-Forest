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
    [ContextMenu("CountCoin")]
    public void CountCoin()
    {
        countCoin += 1;
        coinText.text = countCoin.ToString();
        PlayerPrefs.SetInt(keyName, countCoin);
    }
}
