using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Up_Teras : MonoBehaviour
{
    [SerializeField] private Index_Teras indexTeras;
    [SerializeField] private Buy_Teras buyTeras;
    [SerializeField] private Text upTeras;
    [SerializeField] private GetCoinShop coin;
    [SerializeField] private CoinToUp coinToUp;
    [SerializeField] private HeroAmount amount;
    [SerializeField] private int priceCoin;
    [SerializeField] private Text coinAffterText;
    [SerializeField] private Text priceText;
    [SerializeField] private bool isClick;
    [SerializeField] private string price;

    public int PriceCoin { get => priceCoin; set => priceCoin = value; }

    private void UpHero()
    {
        if (isClick == true)
        {
                if (coin.coinAmount < coinToUp.CoinUp[indexTeras.Number])
                {
                    return;
                }
                if (amount.Index == 2)
                {
                    if (indexTeras.Level == indexTeras.Number + 1)
                    {
                        indexTeras?.UpdateIndex();
                        coinToUp?.UpTeras();
                        if (PriceCoin < 1000)
                        {
                            PriceCoin += 250;
                        }
                        indexTeras.Level += indexTeras.Fixlevel;
                        coinAffterText.text = coinToUp?.CoinUp[indexTeras.Number].ToString();
                    }
                    isClick = false;
                }
        }
    }
    public void IsClick()
    {
        if (buyTeras.BuyTeras == 1)
        {
            isClick = true;
        }
        else if(buyTeras.BuyTeras != 1)
        {
            return;
        }    
    }
    private void PriceText()
    {
        priceText.text = PriceCoin.ToString();
        if (PriceCoin >= 1000)
        {
            upTeras.text = "Max";
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
