using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy_Teras : MonoBehaviour
{
    [SerializeField] private int heroSell;
    [SerializeField] private GetCoinShop coinShop;
    [SerializeField] private bool wasBuy = false;
    [SerializeField] private string keyName;
    [SerializeField] private int buyTeras;
    [SerializeField] private bool isClick;
    public bool WasBuy { get => wasBuy; set => wasBuy = value; }
    public bool IsClick { get => isClick; set => isClick = value; }
    public int BuyTeras { get => buyTeras; set => buyTeras = value; }

    [ContextMenu("WasBuyTeras")]
    private void BuyHeroes()
    {
        if (IsClick == true)
        {
            if (coinShop.coinAmount >= heroSell)
            {
                coinShop.coinAmount -= heroSell;
                BuyTeras = 2;
                WasBuy = true;
                IsClick = false;
            }
            if (coinShop.coinAmount < heroSell)
            {
                return;
            }
        }
    }
    private void WasBuyTeras()
    {
        if (wasBuy == true)
        {
            PlayerPrefs.SetInt(keyName, BuyTeras);
        }
    }
    public void Click()
    {
        IsClick = true;
    }
    private void Start()
    {
        WasBuyTeras();
    }
    private void Update()
    {
        BuyHeroes();
    }
}
