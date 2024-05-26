using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_Aqua : MonoBehaviour
{
    [SerializeField] private Index_Aquana indexAquana;
    //[SerializeField] private Buy_Aqua buyAquana;
    [SerializeField] private GetCoinShop coin;
    [SerializeField] private CoinToUp coinToUp;
    [SerializeField] private HeroAmount amount;
    //[SerializeField] private string keyName;
    //[SerializeField] private int buyAqua;
    [SerializeField] private bool isClick;
    private void UpHero()
    {
        if (isClick == true)
        {
            if (coin.coinAmount < coinToUp.CoinUp[indexAquana.Number])
            {
                return;
            }
            if (amount.Index == 0)
            {
                indexAquana?.UpdateIndex();
                if (indexAquana.Level == indexAquana.Number + 1)
                {
                    coinToUp?.UpAqua();
                    indexAquana.Level += indexAquana.Fixlevel;
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
