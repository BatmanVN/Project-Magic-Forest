using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Index_Teras : MonoBehaviour
{
    [SerializeField] private Index_Bar index;
    [SerializeField] private Image[] terasBar;
    [SerializeField] private float health;
    [SerializeField] private float maxhealth;
    [SerializeField] private float power;
    [SerializeField] private float maxpower;
    [SerializeField] private float speed;
    [SerializeField] private float maxspeed;
    [SerializeField] private float starDame;
    [SerializeField] private float maxstarDame;
    [SerializeField] private int level;
    [SerializeField] private int maxlevel;


    public void IndexsOfTeras()
    {
        for (int i = 0; i < terasBar.Length; i++)
        {
            if (i == 0)
            {
                terasBar[0].fillAmount = health / index.MaxHealthbar;
            }
            if (i == 1)
            {
                terasBar[1].fillAmount = power / index.MaxPowerbar;
            }
            if (i == 2)
            {
                terasBar[2].fillAmount = speed / index.MaxSpeedbar;
            }
            else
            {
                terasBar[3].fillAmount = starDame / index.MaxStarbar;
            }
        }
    }
    //public void HealthTeras()
    //{
    //    igniusBar[0].fillAmount = health / index.MaxHealthbar;
    //}
    //public void PowerTeras()
    //{
    //    igniusBar[1].fillAmount = power / index.MaxPowerbar;
    //}
    //public void SpeedTeras()
    //{
    //    igniusBar[2].fillAmount = speed / index.MaxSpeedbar;
    //}
    //public void StarTeras()
    //{
    //    igniusBar[3].fillAmount = starDame / index.MaxStarbar;
    //}
    private void Start()
    {
        IndexsOfTeras();
    }
}
