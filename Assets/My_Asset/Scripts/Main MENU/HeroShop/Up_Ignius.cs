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
    public void UpHero()
    {
        if (isClick == true)
        {
            if(choose.IndexHero == 0)
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
                        priceText.text = priceCoin.ToString();
                        if (priceCoin >= 1000)
                        {
                            upIgnius.text = "Max";
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
            priceCoin += 250;
        }
    }
    private void Update()
    {
        UpHero();
    }
}
