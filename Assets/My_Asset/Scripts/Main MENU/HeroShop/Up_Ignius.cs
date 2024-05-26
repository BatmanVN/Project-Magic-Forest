using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_Ignius : MonoBehaviour
{
    [SerializeField] private Ignius_Indexs igniusIndex;
    [SerializeField] private GetCoinShop coin;
    [SerializeField] private CoinToUp coinToUp;
    [SerializeField] private HeroAmount amount;
    [SerializeField] private bool isClick;
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
