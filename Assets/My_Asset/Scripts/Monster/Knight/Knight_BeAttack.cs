using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Knight_BeAttack : MonoBehaviour
{
    private const string isAttackParaname = "beAttack";
    private const string isDieParaname = "isDie";
    [SerializeField] private GameObject knightObj;
    [SerializeField] private Animator monsterAnim;
    [SerializeField] private Health monsterCharacter;
    [SerializeField] private Player_attack takeDame;
    [SerializeField] private Player_skillFire skillDame;
    private bool beAttack;

    public bool BeAttack { get => beAttack; set => beAttack = value; }

    private void OnTriggerEnter2D(Collider2D Monster)
    {
        if (Monster.CompareTag("FireBall"))
        {
            monsterAnim.SetTrigger(isAttackParaname);
            if (beAttack == false)
            {
                skillDame?.SkillAmount();
                monsterCharacter.TakeDame(takeDame.dame);
                beAttack = true;
            }
        }
        if(Monster.CompareTag("StarSkill"))
        {
            monsterCharacter.TakeDame(skillDame.dameSkill);
            monsterAnim.SetTrigger(isAttackParaname);
        }
        if (monsterCharacter.isDead)
        {
            monsterAnim.SetTrigger(isDieParaname);
            StartCoroutine(Delay());
        }
    }
    private void OnTriggerExit2D(Collider2D Monster)
    {
        if (Monster.CompareTag("FireBall"))
        {
            beAttack = false;
        }
    }
    private void DisableObj()
    {
        knightObj.SetActive(false);
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        DisableObj();
    }


}
