using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ske_beAtkk : MonoBehaviour
{
    private const string beAttackParaname = "beAttack";
    private const string isDieParaname = "isDie";
    [SerializeField] private Animator skeAnim;
    [SerializeField] private GameObject skeObj;
    [SerializeField] private HealthCharacter skeHealth;
    [SerializeField] private Player_attack takeDame;
    [SerializeField] private Player_skillFire skillDame;
    [SerializeField] private SkeAuto_Move skeMove;
    [SerializeField] private float changeSpeed;
    private bool attkSke;

    public bool AttkSke { get => attkSke; set => attkSke = value; }

    private void OnTriggerEnter2D(Collider2D skeleton)
    {
        if(skeleton.CompareTag("FireBall"))
        {
            AttkSke = true;
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
        if(skeHealth.isDead)
        {
            skeAnim.SetTrigger(isDieParaname);
            StartCoroutine(Delay());
        }
        ChangeAttack();
    }
    private void ChangeAttack()
    {
        if(skeHealth.Health <= 10)
        {
            skeMove?.ChangeSpeed(changeSpeed);
            skeMove.IsChange = false;
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
        
    }
}
