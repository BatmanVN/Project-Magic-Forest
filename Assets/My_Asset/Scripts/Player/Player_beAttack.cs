using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_beAttack : MonoBehaviour
{
    private const string beAttackParaname = "beAttack";
    private const string isDieParaname = "isDie";
    [SerializeField] private InterstitialAdExample ads;
    [SerializeField] private AudioSource beAttackSound;
    [SerializeField] private Health character;
    [SerializeField] private Collider2D player2D;
    [SerializeField] private Player_BonusDef bonusDef;
    [SerializeField] private Attack_Player[] monster;
    [SerializeField] private Ske_attack skeAttk;
    [SerializeField] private Fireman_Attack fireMan;
    [SerializeField] private Animator playerAnim;
    [SerializeField] private Player_jump jump;
    [SerializeField] private float jumpRec;
    [SerializeField] private DieBar dieBar;
    [SerializeField] private float dameSpear;
    [SerializeField] private float dameLeaf;

    private void OnTriggerEnter2D(Collider2D hero)
    {
        if(hero.CompareTag("Spear"))
        {
            jump?.JumpBeAttk(jumpRec);
            playerAnim.SetTrigger(beAttackParaname);
            character?.TakeDame(dameLeaf);
            beAttackSound.Play();
        }
        if(hero.CompareTag("LeafBullet"))
        {
            playerAnim.SetTrigger(beAttackParaname);
            character?.TakeDame(dameSpear);
            beAttackSound.Play();
        }
        if(hero.CompareTag("FiremanBullet"))
        {
            jump?.JumpBeAttk(jumpRec);
            playerAnim.SetTrigger(beAttackParaname);
            character?.TakeDame(fireMan.Dame);
            beAttackSound.Play();
        }
    }
    private void TakeDame()
    {
        for(int i = 0; i < monster.Length; i++)
        {
            if (monster[i].IsEnemy == true && bonusDef.EnableEffect == false)
            {
                jump?.JumpBeAttk(jumpRec);
                beAttackSound.Play();
                playerAnim.SetTrigger(beAttackParaname);
                character?.TakeDame(monster[i].DameKnight);
                monster[i].IsEnemy = false;
            }
        }
        if (character.isDead)
        {
            player2D.enabled = false;
            playerAnim.SetTrigger(isDieParaname);
            ads.ShowAd();
            dieBar?.EnableBar();
        }
    }
    private void TakedameSke()
    {
        if (skeAttk.IsEnemy == true && bonusDef.EnableEffect == false)
        {
            jump?.JumpBeAttk(jumpRec);
            beAttackSound.Play();
            playerAnim.SetTrigger(beAttackParaname);
            character?.TakeDame(skeAttk.Dame);
            skeAttk.IsEnemy = false;
        }
    }

    private void Update()
    {
        TakeDame();
        TakedameSke();
    }
}
