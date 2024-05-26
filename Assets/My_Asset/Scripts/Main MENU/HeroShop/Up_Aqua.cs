using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up_Aqua : MonoBehaviour
{
    [SerializeField] private Index_Aquana indexAquana;
    [SerializeField] private ChooseHero choose;
    [SerializeField] private Text upAqua;
    [SerializeField] private GetCoinShop coin;
    [SerializeField] private CoinToUp coinToUp;
    [SerializeField] private HeroAmount amount;
    [SerializeField] private int priceCoin;
    [SerializeField] private Text coinAffterText;
    [SerializeField] private Text priceText;
    [SerializeField] private bool isClick;
    private void UpHero()
    {
        if (isClick == true)
        {
            if(choose.IndexHero == 1)
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
                        coinAffterText.text = coinToUp?.CoinUp[indexAquana.Number].ToString();
                        priceText.text = priceCoin.ToString();
                        if (priceCoin >= 1000)
                        {
                            upAqua.text = "Max";
                            priceText.text = "Level";
                        }
                    }
                    isClick = false;
                }
            }
        }
    }
    public void IsClick()
    {
        isClick = true;
        if (priceCoin < 1000)
        {
            if(choose.IndexHero == 1)
                priceCoin += 250;
        }
    }
    private void Update()
    {
        UpHero();
    }
}
