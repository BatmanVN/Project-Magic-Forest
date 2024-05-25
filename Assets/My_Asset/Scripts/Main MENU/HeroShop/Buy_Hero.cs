using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy_Hero : MonoBehaviour
{
    //[SerializeField] private GameObject heroBuy;
    [SerializeField] private int heroSell;
    [SerializeField] private HeroManager heroManager;
    [SerializeField] private GetCoinShop coinShop;
    [SerializeField] private bool isBuy;
    [SerializeField] private bool wasBuy;

    public bool WasBuy { get => wasBuy; set => wasBuy = value; }

    private void BuyHeroes()
    {
            if (isBuy)
            {
                if(coinShop.coinAmount >= heroSell)
                {
                    coinShop.coinAmount -= heroSell;
                    WasBuy = true;
                }
            }
    }
    public void BuyHero()
    {
        isBuy = true;
    }
    private void Update()
    {
        BuyHeroes();
    }
}
