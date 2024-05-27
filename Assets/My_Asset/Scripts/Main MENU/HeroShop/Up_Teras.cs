using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Up_Teras : MonoBehaviour
{
    [SerializeField] private Index_Teras indexTeras;
    [SerializeField] private ChooseHero choose;
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
            if(choose.WasChoose == true)
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
                        indexTeras.Level += indexTeras.Fixlevel;
                        coinAffterText.text = coinToUp?.CoinUp[indexTeras.Number].ToString();
                    }
                    isClick = false;
                }
            }
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
