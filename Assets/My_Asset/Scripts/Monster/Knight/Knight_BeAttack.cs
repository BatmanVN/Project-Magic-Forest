using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Knight_BeAttack : MonoBehaviour
{
    private const string isAttackParaname = "beAttack";
    private const string isDieParaname = "isDie";
    [SerializeField] private GameObject knightObj;
    [SerializeField] private Animator monsterAnim;
    [SerializeField] private Health monsterCharacter;
    [SerializeField] private Player_attack takeDame;
    [SerializeField] private Player_skillFire skillDame;
    [SerializeField] private int point;
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
            PlayGamesPlatform.Instance.IncrementAchievement(GPGSIds.achievement_kill_knight, 1, (bool success) => {
            });

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
