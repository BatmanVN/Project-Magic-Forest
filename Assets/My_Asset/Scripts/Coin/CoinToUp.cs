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
    [SerializeField] private GameObject[] textHero;
    [SerializeField] private Ignius_Indexs igniusIndex;
    [SerializeField] private Index_Aquana aquanaIndex;
    [SerializeField] private Index_Teras terasIndex;
    [SerializeField] private int[] coinUp;
    [SerializeField] private string keyName;
    [SerializeField] private string healthName;
    [SerializeField] private string powerName;
    [SerializeField] private string speedName;
    [SerializeField] private string starName;
    [SerializeField] private string levelName;
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
                PlayerPrefs.SetFloat(healthName, igniusIndex.Health);
                PlayerPrefs.SetFloat(powerName, igniusIndex.Power);
                PlayerPrefs.SetFloat(speedName, igniusIndex.Speed);
                PlayerPrefs.SetFloat(starName, igniusIndex.StarDame);
                PlayerPrefs.SetInt(levelName, igniusIndex.Level);
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
                PlayerPrefs.SetFloat(healthName, aquanaIndex.Health);
                PlayerPrefs.SetFloat(powerName, aquanaIndex.Power);
                PlayerPrefs.SetFloat(speedName, aquanaIndex.Speed);
                PlayerPrefs.SetFloat(starName, aquanaIndex.StarDame);
                PlayerPrefs.SetInt(levelName, aquanaIndex.Level);
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
                PlayerPrefs.SetFloat(healthName, terasIndex.Health);
                PlayerPrefs.SetFloat(powerName, terasIndex.Power);
                PlayerPrefs.SetFloat(speedName, terasIndex.Speed);
                PlayerPrefs.SetFloat(starName, terasIndex.StarDame);
                PlayerPrefs.SetInt(levelName, terasIndex.Level);
            }
        }
    }
    private void KeyName()
    {
        if(amount.Index == 0)
        {
            healthName = "IgHealth";
            powerName = "IgPower";
            speedName = "IgSpeed";
            starName = "IgStar";
            levelName = "IgLevel";
        }
        if(amount.Index == 1)
        {
            healthName = "AquaHealth";
            powerName = "AquanPower";
            speedName = "AquaSpeed";
            starName = "AquaStar";
            levelName = "AquaLevel";
        }
        if (amount.Index == 2)
        {
            healthName = "TerasHealth";
            powerName = "TerasPower";
            speedName = "TerasSpeed";
            starName = "TerasStar";
            levelName = "TerasLevel";
        }
    }
    private void Update()
    {
        KeyName();
    }
    private void Start()
    {
        
    }
}
