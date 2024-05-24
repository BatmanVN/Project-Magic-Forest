using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoinShop : MonoBehaviour
{
    [SerializeField] private string coinName;
    [SerializeField] private int getCoin;
    [SerializeField] private Text coinShop;
    [SerializeField] private CoinToUp coinSave;
    public int coinAmount { get => getCoin; set => getCoin = value; }

    [ContextMenu("Get")]
    private void Start()
    {
        Get();
    }
    private int Get()
    {
        coinAmount = PlayerPrefs.GetInt(coinName, getCoin);
        return coinAmount;
    }
    private void TextCoin()
    {
        coinShop.text = coinAmount.ToString();
    }
    private void Update()
    {
        TextCoin();
    }
}
