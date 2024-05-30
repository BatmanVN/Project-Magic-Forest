using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Up_Aqua : MonoBehaviour
{
    [SerializeField] private Index_Aquana indexAquana;
    [SerializeField] private Buy_Aqua wasBuy;
    [SerializeField] private Text upAqua;
    [SerializeField] private GetCoinShop coin;
    [SerializeField] private CoinToUp coinToUp;
    [SerializeField] private HeroAmount amount;
    [SerializeField] private int priceCoin;
    [SerializeField] private Text coinAffterText;
    [SerializeField] private Text priceText;
    [SerializeField] private bool isClick;
    [SerializeField] private string price;

    public int PriceCoin { get => priceCoin; set => priceCoin = value; }
    [ContextMenu("GetPrice")]
    private void UpHero()
    {
        if (isClick == true)
        {
                if (coin.coinAmount < coinToUp.CoinUp[indexAquana.Number])
                {
                    return;
                }
                if (amount.Index == 1)
                {
                    indexAquana?.UpdateIndex();
                    if (indexAquana.Level == indexAquana.Number + 1)
                    {
                        coinToUp?.UpAqua();
                        indexAquana.Level += indexAquana.Fixlevel;
                    if (PriceCoin < 1000)
                    {
                            PriceCoin += 250;
                    }
                    coinAffterText.text = coinToUp?.CoinUp[indexAquana.Number].ToString();
                    }
                    isClick = false;
                }
        }
    }
    public void IsClick()
    {
        if (wasBuy.BuyAqua == 1)
        {
            isClick = true;
        }
        else if(wasBuy.BuyAqua != 1)
        {
            return;
        }
    }
    private void PriceText()
    {
        priceText.text = PriceCoin.ToString();
        if (PriceCoin >= 1000)
        {
            upAqua.text = "Max";
            priceText.text = "Level";
        }
    }
    private int GetPrice()
    {
        PriceCoin = PlayerPrefs.GetInt(price, PriceCoin);
        return PriceCoin;
    }
    private void Start()
    {
        GetPrice();
    }
    private void Update()
    {
        UpHero();
        PriceText();
    }
}
