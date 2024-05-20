using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Index_Aquana : MonoBehaviour
{
    [SerializeField] private Index_Bar index;
    [SerializeField] private Image[] aquanaBar;
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


    public void IndexsOfAquana()
    {
        for (int i = 0; i < aquanaBar.Length; i++)
        {
            if (i == 0)
            {
                aquanaBar[0].fillAmount = health / index.MaxHealthbar;
            }
            if (i == 1)
            {
                aquanaBar[1].fillAmount = power / index.MaxPowerbar;
            }
            if (i == 2)
            {
                aquanaBar[2].fillAmount = speed / index.MaxSpeedbar;
            }
            else
            {
                aquanaBar[3].fillAmount = starDame / index.MaxStarbar;
            }
        }
    }
    //public void HealthAquana()
    //{
    //    igniusBar[0].fillAmount = health / index.MaxHealthbar;
    //}
    //public void PowerAquana()
    //{
    //    igniusBar[1].fillAmount = power / index.MaxPowerbar;
    //}
    //public void SpeedAquana()
    //{
    //    igniusBar[2].fillAmount = speed / index.MaxSpeedbar;
    //}
    //public void StarAquana()
    //{
    //    igniusBar[3].fillAmount = starDame / index.MaxStarbar;
    //}
    private void Start()
    {
        IndexsOfAquana();
    }
}
