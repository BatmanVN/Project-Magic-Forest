using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Index_Aquana : MonoBehaviour
{
    [SerializeField] private Index_Bar index;
    [SerializeField] private Image[] aquanaBar;
    [SerializeField] private Text[] aquanaText;
    [SerializeField] private float health;
    [SerializeField] private float power;
    [SerializeField] private float speed;
    [SerializeField] private float starDame;
    [SerializeField] private int level;
    [SerializeField] private Index_Bar index_Bar;
    [SerializeField] private float fixHealth;
    [SerializeField] private float fixPower;
    [SerializeField] private float fixSpeed;
    [SerializeField] private float fixStarDame;
    [SerializeField] private int fixlevel;
    [SerializeField] private int number;
    public float Health { get => health; set => health = value; }
    public float Power { get => power; set => power = value; }
    public float Speed { get => speed; set => speed = value; }
    public float StarDame { get => starDame; set => starDame = value; }
    public int Level { get => level; set => level = value; }
    public int Fixlevel { get => fixlevel; set => fixlevel = value; }
    public int Number { get => number; set => number = value; }

    public void IndexsOfAquana()
    {
        for (int i = 0; i < aquanaBar.Length; i++)
        {
            if (i == 0)
            {
                aquanaText[0].text = Health.ToString();
                aquanaBar[0].fillAmount = Health / index.MaxHealthbar;
            }
            if (i == 1)
            {
                aquanaText[1].text = Power.ToString();
                aquanaBar[1].fillAmount = Power / index.MaxPowerbar;
            }
            if (i == 2)
            {
                aquanaText[2].text = Speed.ToString();
                aquanaBar[2].fillAmount = Speed / index.MaxSpeedbar;
            }
            if(i == 3)
            {
                aquanaText[3].text = StarDame.ToString();
                aquanaBar[3].fillAmount = StarDame / index.MaxStarbar;
            }
            else
            {
                aquanaText[4].text = Level.ToString();
            }
        }
    }
    public void UpdateIndex()
    {
        if (Health > index_Bar.MaxHealthbar || Power > index_Bar.MaxPowerbar
            || Speed > index_Bar.MaxSpeedbar || StarDame > index_Bar.MaxStarbar || Level >= index_Bar.MaxLevel)
        {
            return;
        }
        Health += fixHealth;
        Power += fixPower;
        Speed += fixSpeed;
        StarDame += fixStarDame;
    }
    private void Update()
    {
        IndexsOfAquana();
    }
}
