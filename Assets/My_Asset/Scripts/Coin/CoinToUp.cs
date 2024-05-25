using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinToUp : MonoBehaviour
{
    [SerializeField] private HeroAmount amount;
    [SerializeField] private GetCoinShop coin;
    [SerializeField] private Index_Bar maxLevel;
    //[SerializeField] private SaveCoinShop saveCoin;
    [SerializeField] private GameObject[] textHero;
    [SerializeField] private Ignius_Indexs igniusIndex;
    [SerializeField] private Index_Aquana aquanaIndex;
    [SerializeField] private Index_Teras terasIndex;
    [SerializeField] private int[] coinUp;
    [SerializeField] private Text coinAffterText;
    [SerializeField] private string keyName;
    public int[] CoinUp { get => coinUp; set => coinUp = value; }
    [ContextMenu("CointoUp")]
    public void UpgradeHero()
    {
        if (coin.coinAmount < coinUp[igniusIndex.Number] || coin.coinAmount < coinUp[aquanaIndex.Number]
        || coin.coinAmount < coinUp[terasIndex.Number])
        {
            return;
        }
        for (int i = 0; i < textHero.Length; i++)
        {
            if (textHero[i] == textHero[amount.Index])
            {
                textHero[amount.Index].SetActive(true);
                if (amount.Index == 0)
                {
                    igniusIndex?.UpdateIndex();
                    if(igniusIndex.Level == igniusIndex.Number + 1)
                    {
                        UpIgnius();
                        igniusIndex.Level += igniusIndex.Fixlevel;
                    }
                }
                if (amount.Index == 1)
                {

                    aquanaIndex?.UpdateIndex();
                    if (aquanaIndex.Level == aquanaIndex.Number + 1)
                    {
                        UpAqua();
                        aquanaIndex.Level += aquanaIndex.Fixlevel;
                    }
                }
                if (amount.Index == 2)
                {
                    terasIndex?.UpdateIndex();
                    if (terasIndex.Level == terasIndex.Number + 1)
                    {
                        UpTeras();
                        terasIndex.Level += terasIndex.Fixlevel;
                    }
                }
            }
            else
            {
                textHero[i].SetActive(false);
            }
        }
    }
    private void UpIgnius()
    {
        if(igniusIndex.Number <3)
        {
            if (coin.coinAmount >= coinUp[igniusIndex.Number])
            {
                coin.coinAmount -= coinUp[igniusIndex.Number];
                igniusIndex.Number += 1;
                coinAffterText.text = coinUp.ToString();
                PlayerPrefs.SetInt(keyName, coin.coinAmount);
            }
        }
    }
    private void UpAqua()
    {
        if (aquanaIndex.Number < 3)
        {
            if (coin.coinAmount >= coinUp[aquanaIndex.Number])
            {
                coin.coinAmount -= coinUp[aquanaIndex.Number];
                aquanaIndex.Number += 1;
                coinAffterText.text = coinUp.ToString();
                PlayerPrefs.SetInt(keyName, coin.coinAmount);
            }
        }
    }
    private void UpTeras()
    {
        if (terasIndex.Number < 3)
        {
            if (coin.coinAmount >= coinUp[terasIndex.Number])
            {
                coin.coinAmount -= coinUp[terasIndex.Number];
                terasIndex.Number += 1;
                coinAffterText.text = coinUp.ToString();
                PlayerPrefs.SetInt(keyName, coin.coinAmount);
            }
        }
    }
    private void Start()
    {
        
    }
}
