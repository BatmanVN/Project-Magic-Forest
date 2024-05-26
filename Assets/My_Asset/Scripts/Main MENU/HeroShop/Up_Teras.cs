using System.Collections;
using System.Collections.Generic;
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

    private void UpHero()
    {
        if (isClick == true)
        {
            if(choose.IndexHero == 2)
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
                        priceText.text = priceCoin.ToString();
                        if (priceCoin >= 1000)
                        {
                            upTeras.text = "Max";
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
        if(priceCoin <= 1000)
        {
            priceCoin += 250;
        }
    }
    private void Update()
    {
        UpHero();
    }
}
