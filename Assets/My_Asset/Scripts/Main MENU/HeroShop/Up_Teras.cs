using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_Teras : MonoBehaviour
{
    [SerializeField] private Index_Teras indexTeras;
    [SerializeField] private GetCoinShop coin;
    [SerializeField] private CoinToUp coinToUp;
    [SerializeField] private HeroAmount amount;
    //[SerializeField] private string keyName;
    //[SerializeField] private int buyTeras;
    [SerializeField] private bool isClick;

    private void UpHero()
    {
        if (isClick == true)
        {
            if (coin.coinAmount < coinToUp.CoinUp[indexTeras.Number])
            {
                return;
            }
            if (amount.Index == 0)
            {
                indexTeras?.UpdateIndex();
                if (indexTeras.Level == indexTeras.Number + 1)
                {
                    coinToUp?.UpTeras();
                    indexTeras.Level += indexTeras.Fixlevel;
                }
                isClick = false;
            }
        }
    }
    public void IsClick()
    {
        isClick = true;
    }
    private void Update()
    {
        UpHero();
    }
}
