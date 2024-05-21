using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ignius_Indexs : MonoBehaviour
{
    [SerializeField] private Index_Bar index;
    [SerializeField] private Image[] igniusBar;
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

    
    public void IndexsOfIgnius()
    {
        for (int i = 0; i < igniusBar.Length; i++)
        {
            if(i == 0)
            {
                igniusBar[0].fillAmount = health / index.MaxHealthbar;
            }
            if(i == 1)
            {
                igniusBar[1].fillAmount = power / index.MaxPowerbar;
            }
            if(i == 2)
            {
                igniusBar[2].fillAmount = speed / index.MaxSpeedbar;
            }
            else
            {
                igniusBar[3].fillAmount = starDame / index.MaxStarbar;
            }
        }
    }
    //public void HealthIgnius()
    //{
    //    igniusBar[0].fillAmount = health / index.MaxHealthbar;
    //}
    //public void PowerIgnius()
    //{
    //    igniusBar[1].fillAmount = power / index.MaxPowerbar;
    //}
    //public void SpeedIgnius()
    //{
    //    igniusBar[2].fillAmount = speed / index.MaxSpeedbar;
    //}
    //public void StarIgnius()
    //{
    //    igniusBar[3].fillAmount = starDame / index.MaxStarbar;
    //}
    private void Update()
    {
        IndexsOfIgnius();
    }
}
