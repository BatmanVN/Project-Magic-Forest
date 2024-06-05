using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up_Ignius : MonoBehaviour
{
    [SerializeField] private Ignius_Indexs igniusIndex;
    [SerializeField] private ChooseHero choose;
    [SerializeField] private Text upIgnius;
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
    public void UpHero()
    {
        if (isClick == true)
        {
            if (coin.coinAmount < coinToUp.CoinUp[igniusIndex.Number])
            {
                return;
            }
            if (amount.Index == 0)
            {
                igniusIndex?.UpdateIndex();
                if (igniusIndex.Level == igniusIndex.Number + 1)
                {
                    coinToUp?.UpIgnius();
                    igniusIndex.Level += igniusIndex.Fixlevel;
                    coinAffterText.text = coinToUp?.CoinUp[igniusIndex.Number].ToString();
                }
                isClick = false;
            }
        }
    }
    public void IsClick()
    {
        if (coin.coinAmount > coinToUp.CoinUp[igniusIndex.Number])
        {
            isClick = true;
            if (PriceCoin < 1000)
            {
                PriceCoin += 250;
            }
        }
    }
    private void PriceText()
    {
        priceText.text = PriceCoin.ToString();
        if (PriceCoin >= 1000)
        {
            upIgnius.text = "Max";
            priceText.text = "Level";
        }
    }
    private int GetPrice()
    {
        PriceCoin = PlayerPrefs.GetInt(price, priceCoin);
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
