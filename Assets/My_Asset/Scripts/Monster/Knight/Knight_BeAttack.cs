using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_BeAttack : MonoBehaviour
{
    private const string isAttackParaname = "beAttack";
    [SerializeField] private Animator monsterAnim;
    [SerializeField] private HealthCharacter monsterCharacter;
    [SerializeField] private Player_attack takeDame;
    [SerializeField] private Player_skillFire skillDame;
    private Player_skillFire starFire;
    public bool beAttack;
    private void OnTriggerEnter2D(Collider2D Monster)
    {
        if (Monster.CompareTag("FireBall"))
        {
            monsterAnim.SetTrigger(isAttackParaname);
            monsterCharacter.TakeDame(takeDame.dame);
            starFire?.SkillAmount();
        }
        if(Monster.CompareTag("StarSkill"))
        {
            monsterCharacter.TakeDame(skillDame.dameSkill);
            monsterAnim.SetTrigger(isAttackParaname);
        }
    }


    private void Start()
    {
        starFire = FindAnyObjectByType<Player_skillFire>();
    }


}
