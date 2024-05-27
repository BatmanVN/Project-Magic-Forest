using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Cinemachine.DocumentationSortingAttribute;

public class CoinToUp : MonoBehaviour
{
    [SerializeField] private HeroAmount amount;
    [SerializeField] private GetCoinShop coin;
    [SerializeField] private Index_Bar maxLevel;
    [SerializeField] private Ignius_Indexs igniusIndex;
    [SerializeField] private Index_Aquana aquanaIndex;
    [SerializeField] private Index_Teras terasIndex;
    [SerializeField] private int[] coinUp;
    [SerializeField] private string keyName;
    public int[] CoinUp { get => coinUp; set => coinUp = value; }

    [ContextMenu("CointoUp")]
    public void UpIgnius()
    {
        if(igniusIndex.Number < 3)
        {
            if (coin.coinAmount >= coinUp[igniusIndex.Number])
            {
                coin.coinAmount -= coinUp[igniusIndex.Number];
                igniusIndex.Number += 1;
                PlayerPrefs.SetInt(keyName, coin.coinAmount);
            }
        }
    }
    public void UpAqua()
    {
        if (aquanaIndex.Number < 3)
        {
            if (coin.coinAmount >= coinUp[aquanaIndex.Number])
            {
                coin.coinAmount -= coinUp[aquanaIndex.Number];
                aquanaIndex.Number += 1;
                PlayerPrefs.SetInt(keyName, coin.coinAmount);
            }
        }
    }
    public void UpTeras()
    {
        if (terasIndex.Number < 3)
        {
            if (coin.coinAmount >= coinUp[terasIndex.Number])
            {
                coin.coinAmount -= coinUp[terasIndex.Number];
                terasIndex.Number += 1;
                PlayerPrefs.SetInt(keyName, coin.coinAmount);
            }
        }
    }
    private void Start()
    {
        
    }
}
