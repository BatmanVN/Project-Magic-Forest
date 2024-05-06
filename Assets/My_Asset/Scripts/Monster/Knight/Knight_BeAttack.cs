using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_BeAttack : MonoBehaviour
{
    private const string isAttackParaname = "beAttack";
    [SerializeField] private Animator monsterAnim;
    [SerializeField] private HealthCharacter monsterCharacter;
    [SerializeField] private Player_attack takeDame;
    private Player_skillFire starFire;
    public bool beAttack;
    private void OnTriggerEnter2D(Collider2D Monster)
    {
        if (Monster.CompareTag("FireBall"))
        {
            monsterAnim.SetTrigger(isAttackParaname);
            monsterCharacter.TakeDame(takeDame.dame);
            beAttack = true;
            starFire?.SkillAmount();
        }
    }
    private void Start()
    {
        starFire = FindAnyObjectByType<Player_skillFire>();
    }
}
