using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy_Aqua : MonoBehaviour
{
    [SerializeField] private int heroSell;
    [SerializeField] private GetCoinShop coinShop;
    [SerializeField] private bool wasBuy = false;
    [SerializeField] private string keyName;
    [SerializeField] private int buyAqua;
    [SerializeField] private bool isClick;
    public bool WasBuy { get => wasBuy; set => wasBuy = value; }
    public bool IsClick { get => isClick; set => isClick = value; }
    public int BuyAqua { get => buyAqua; set => buyAqua = value; }

    [ContextMenu("WasBuyAqua")]
    private void BuyHeroes()
    {
        if (IsClick == true)
        {
            if (coinShop.coinAmount >= heroSell)
            {
                coinShop.coinAmount -= heroSell;
                BuyAqua = 1;
                PlayerPrefs.SetInt(keyName, BuyAqua);
                WasBuy = true;
                IsClick = false;
            }
            if (coinShop.coinAmount < heroSell)
            {
                return;
            }
        }
    }
    //private void WasBuyAqua()
    //{
    //    if (wasBuy == true)
    //    {
    //        PlayerPrefs.SetInt(keyName, BuyAqua);
    //    }
    //}
    public void Click()
    {
        IsClick = true;
    }
    //private void Start()
    //{
    //    WasBuyAqua();
    //}
    private void Update()
    {
        BuyHeroes();
    }
}
