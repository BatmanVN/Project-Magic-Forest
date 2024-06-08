using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ske_beAtkk : MonoBehaviour
{
    private const string beAttackParaname = "beAttack";
    private const string isDieParaname = "isDie";
    [SerializeField] private Animator skeAnim;
    [SerializeField] private GameObject skeObj;
    [SerializeField] private Health skeHealth;
    [SerializeField] private Player_attack takeDame;
    [SerializeField] private Player_skillFire skillDame;
    [SerializeField] private SkeAuto_Move skeMove;
    [SerializeField] private float changeSpeed;

    private bool attkSke;
    private bool skillAttk;
    private bool changespeed;
    public bool AttkSke { get => attkSke; set => attkSke = value; }

    private void OnTriggerEnter2D(Collider2D skeleton)
    {
        if(skeleton.CompareTag("FireBall"))
        {
            skeAnim.SetTrigger(beAttackParaname);
            //if (attkSke == false)
            //{
                skillDame?.SkillAmount();
                skeHealth.TakeDame(takeDame.DameSke);
            //    attkSke = true;
            //}
        }
        if(skeleton.CompareTag("StarSkill"))
        {
            skeAnim.SetTrigger(beAttackParaname);
            if (skillAttk == false)
            {
                skillDame?.SkilltoSke();
                skeHealth?.TakeDame(skillDame.dameSkill);
                skillAttk = true;
            }
        }
        if(skeHealth.isDead)
        {
            Social.ReportProgress(GPGSIds.achievement_the_skeleton_king, 100.0f, (bool success) => {
            });
            if (Social.localUser.authenticated == true)
            {
                Social.ReportScore(5, GPGSIds.leaderboard_monster_slayer, (bool success) =>
                {
                });
            }
            else
            {
                return;
            }
            skeAnim.SetTrigger(isDieParaname);
            StartCoroutine(Delay());
        }
    }
    public void ChangeAttack()
    {
        if(skeHealth.HealTH <= 10)
        {
            if(changespeed == false)
            {
                skeMove?.ChangeSpeed(changeSpeed);
                changespeed = true;
            }
        }
    }
    private void DisableObj()
    {
        skeObj.SetActive(false);
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        DisableObj();
    }
    private void Update()
    {
        ChangeAttack();
    }
    private void Start()
    {

    }
}
