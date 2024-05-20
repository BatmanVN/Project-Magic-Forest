using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_skillFire : MonoBehaviour
{
    [SerializeField] private Image skillBar;
    [SerializeField] private GameObject buttonStar;
    [SerializeField] private GameObject starPower;
    [SerializeField] private SpriteRenderer fireRender;
    [SerializeField] private Player_Move move;
    [SerializeField] private Transform fireBall;
    [SerializeField] private float dameskill;
    [SerializeField] private float excatlySkill;
    [SerializeField] private float maxSkillAmount;
    public float dameSkill { get => dameskill;private set => dameskill = value; }
    public bool starEnable => excatlySkill >= maxSkillAmount;
    public void SkilltoSke()
    {
        dameskill -= 2;
    }
    public void SkillAmount()
    {
        if(starEnable)
        {
            return;
        }
        excatlySkill += 1;
        skillBar.fillAmount = excatlySkill / maxSkillAmount;
    }
    public void FirePower()
    {
        if (move.IsFlip == true)
        {
            fireRender.flipX = true;
        }
        if (move.IsFlip == false)
        {
            fireRender.flipX = false;
        }
        if (starEnable == true)
        {
            Instantiate(starPower,fireBall.position,Quaternion.identity);
            excatlySkill -= maxSkillAmount;
            skillBar.fillAmount = excatlySkill / maxSkillAmount;
        }
    }
    private void Update()
    {
        
    }
}
