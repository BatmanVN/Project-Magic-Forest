using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class Index_Teras : MonoBehaviour
{
    [SerializeField] private Index_Bar index;
    [SerializeField] private Image[] terasBar;
    [SerializeField] private Text[] terasText;
    [SerializeField] private float health;
    [SerializeField] private float power;
    [SerializeField] private float speed;
    [SerializeField] private float starDame;
    [SerializeField] private int level;
    [SerializeField] private int maxlevel;
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

    public void IndexsOfTeras()
    {
        for (int i = 0; i < terasBar.Length; i++)
        {
            if (i == 0)
            {
                terasText[0].text = Health.ToString();
                terasBar[0].fillAmount = Health / index.MaxHealthbar;
            }
            if (i == 1)
            {
                terasText[1].text = Power.ToString();
                terasBar[1].fillAmount = Power / index.MaxPowerbar;
            }
            if (i == 2)
            {
                terasText[2].text = Speed.ToString();
                terasBar[2].fillAmount = Speed / index.MaxSpeedbar;
            }
            if(i == 3)
            {
                terasText[3].text = StarDame.ToString();
                terasBar[3].fillAmount = StarDame / index.MaxStarbar;
            }
            else
            {
                terasText[4].text = Level.ToString();
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
        IndexsOfTeras();
    }
}
