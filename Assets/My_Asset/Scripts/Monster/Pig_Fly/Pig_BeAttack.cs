using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig_BeAttack : MonoBehaviour
{
    private const string isAttackParaname = "beAttack";
    private const string isDieParaname = "isDie";
    [SerializeField] private GameObject pigObj;
    [SerializeField] private Animator pigAnim;
    [SerializeField] private Health pigHP;
    [SerializeField] private Player_attack takeDame;
    [SerializeField] private Player_skillFire skillDame;
    private bool beAttack;
    public bool BeAttack { get => beAttack; set => beAttack = value; }


    private void OnTriggerEnter2D(Collider2D Monster)
    {
        if (Monster.CompareTag("FireBall"))
        {
            pigAnim.SetTrigger(isAttackParaname);
            if (beAttack == false)
            {
                skillDame?.SkillAmount();
                pigHP.TakeDame(takeDame.dame);
                beAttack = true;
            }
        }
        if (Monster.CompareTag("StarSkill"))
        {
            pigHP.TakeDame(skillDame.dameSkill);
            pigAnim.SetTrigger(isAttackParaname);
        }
        if (pigHP.isDead)
        {
            //PlayGamesPlatform.Instance.IncrementAchievement(GPGSIds.achievement_kill_knight, 1, (bool success) => {
            //});

            pigAnim.SetTrigger(isDieParaname);
            StartCoroutine(Delay());
        }
    }

    private void DisableObj()
    {
        pigObj.SetActive(false);
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        DisableObj();
    }
}
