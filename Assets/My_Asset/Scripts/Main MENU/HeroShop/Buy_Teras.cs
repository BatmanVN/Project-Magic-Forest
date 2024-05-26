using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy_Teras : MonoBehaviour
{
    [SerializeField] private int heroSell;
    [SerializeField] private HeroManager heroManager;
    [SerializeField] private GetCoinShop coinShop;
    [SerializeField] private bool wasBuy = false;
    [SerializeField] private string keyName;
    [SerializeField] private int buyTeras;
    [SerializeField] private bool isClick;
    public bool WasBuy { get => wasBuy; set => wasBuy = value; }
    public bool IsClick { get => isClick; set => isClick = value; }

    [ContextMenu("WasBuyTeras")]
    private void BuyHeroes()
    {
        if(IsClick == true)
        {
                if (coinShop.coinAmount >= heroSell)
                {
                    coinShop.coinAmount -= heroSell;
                    buyTeras = 2;
                    WasBuy = true;
                }
        }
    }
    private void WasBuyTeras()
    {
        if (wasBuy == true)
        {
            PlayerPrefs.SetInt(keyName, buyTeras);
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
