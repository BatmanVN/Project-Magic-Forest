using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireman_beattack : MonoBehaviour
{
    private const string isAttackParaname = "beAttack";
    private const string isDieParaname = "isDie";
    [SerializeField] private GameObject firemanObj;
    [SerializeField] private Animator monsterAnim;
    [SerializeField] private Health firemanHealth;
    [SerializeField] private Player_attack takeDame;
    [SerializeField] private Player_skillFire skillDame;
    private bool beAttack;
    public bool BeAttack { get => beAttack; set => beAttack = value; }


    private void OnTriggerEnter2D(Collider2D fireMan)
    {
        if (fireMan.CompareTag("FireBall"))
        {
            monsterAnim.SetTrigger(isAttackParaname);
                skillDame?.SkillAmount();
                firemanHealth.TakeDame(takeDame.dame);
                beAttack = true;
        }
        if (fireMan.CompareTag("StarSkill"))
        {
            firemanHealth.TakeDame(skillDame.dameSkill);
            monsterAnim.SetTrigger(isAttackParaname);
        }
        if (firemanHealth.isDead)
        {
            Social.ReportProgress(GPGSIds.achievement_kill_fireman, 100.0f, (bool success) => {
            });
            if (Social.localUser.authenticated == true)
            {
                Social.ReportScore(10, GPGSIds.leaderboard_monster_slayer, (bool success) =>
                {
                });
            }
            else
            {
                return;
            }
            monsterAnim.SetTrigger(isDieParaname);
            StartCoroutine(Delay());
        }
    }
    private void DisableObj()
    {
        firemanObj.SetActive(false);
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        DisableObj();
    }
}
