using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_BeAttack : MonoBehaviour
{
    private const string isAttackParaname = "beAttack";
    [SerializeField] private Animator monsterAnim;
    [SerializeField] private HealthCharacter monsterCharacter;
    [SerializeField] private Player_attack takeDame;
    public bool beAttack;
    private void OnTriggerEnter2D(Collider2D Monster)
    {
        if (Monster.CompareTag("FireBall"))
        {
            monsterAnim.SetTrigger(isAttackParaname);
            monsterCharacter.TakeDame(takeDame.dame);
            beAttack = true;
        }
    }
    private void OnTriggerExit2D(Collider2D Monster)
    {
        if (Monster.CompareTag("FireBall"))
        {
            beAttack = false;
        }
    }
    private void Update()
    {
        
    }
}
