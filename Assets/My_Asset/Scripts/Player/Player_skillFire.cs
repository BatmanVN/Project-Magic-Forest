using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_skillFire : MonoBehaviour
{
    [SerializeField] private int excatlySkill;
    [SerializeField] private GameObject buttonStar;
    [SerializeField] private GameObject starPower;
    [SerializeField] private SpriteRenderer fireRender;
    [SerializeField] private Player_Move move;
    [SerializeField] private Transform fireBall;
    public bool starEnable;
    public void SkillAmount()
    {
        excatlySkill += 1;
        if(excatlySkill > 5)
        {
            return;
        }
        if(excatlySkill == 5)
        {
            buttonStar.SetActive(true);
            starEnable = true;
        }
    }
    public void FirePower()
    {
        if (move.isFlip == true)
        {
            fireRender.flipX = true;
        }
        if (move.isFlip == false)
        {
            fireRender.flipX = false;
        }
        if (starEnable == true)
        {
            Instantiate(starPower,fireBall.position,Quaternion.identity);
            excatlySkill = 0;
        }
    }
}
