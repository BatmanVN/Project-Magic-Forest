using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ske_beAtkk : MonoBehaviour
{
    private const string beAttackParaname = "beAttack";
    [SerializeField] private Animator skeAnim;
    [SerializeField] private HealthCharacter skeHealth;
    [SerializeField] private Player_attack takeDame;
    [SerializeField] private Player_skillFire skillDame;
    public bool attkSke;
    private void OnTriggerEnter2D(Collider2D skeleton)
    {
        if(skeleton.CompareTag("FireBall"))
        {
            attkSke = true;
            skeAnim.SetTrigger(beAttackParaname);
            skeHealth.TakeDame(takeDame.DameSke);
            skillDame?.SkillAmount();
           
        }
        if(skeleton.CompareTag("StarSkill"))
        {
            skeAnim.SetTrigger(beAttackParaname);
            skillDame?.SkilltoSke();
            skeHealth?.TakeDame(skillDame.dameSkill);
        }
    }
    private void Update()
    {
        
    }
}
