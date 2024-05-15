using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_beAttack : MonoBehaviour
{
    private const string beAttackParaname = "beAttack";
    private const string isDieParaname = "isDie";
    [SerializeField] private HealthCharacter character;
    [SerializeField] private Collider2D player2D;
    [SerializeField] private Player_BonusDef bonusDef;
    [SerializeField] private Attack_Player[] monster;
    [SerializeField] private Ske_attack skeAttk;
    [SerializeField] private Animator playerAnim;
    [SerializeField] private Player_jump jump;
    [SerializeField] private float jumpRec;
    [SerializeField] private DieBar dieBar;
    public bool beAttack;
    //private void OnTriggerEnter2D(Collider2D player)
    //{
    //    if(player.CompareTag("KinghtMonster"))
    //    {
    //        beAttack = true;
    //        playerAnim.SetTrigger(beAttackParaname);
    //        jump?.JumpBeAttk(jumpRec);
    //    }
    //}
    private void TakeDame()
    {
        for(int i = 0; i < monster.Length; i++)
        {
            if (monster[i].isEnemy == true && bonusDef.enableEffect == false)
            {
                jump?.JumpBeAttk(jumpRec);
                playerAnim.SetTrigger(beAttackParaname);
                character?.TakeDame(monster[i].DameKnight);
                monster[i].isEnemy = false;
                //beAttack = true;
            }
        }
        if(skeAttk.isEnemy == true && bonusDef.enableEffect == false)
        {
            jump?.JumpBeAttk(jumpRec);
            playerAnim.SetTrigger(beAttackParaname);
            character?.TakeDame(skeAttk.Dame);
            skeAttk.isEnemy = false;
        }
        if (character.isDead)
        {
            player2D.enabled = false;
            playerAnim.SetTrigger(isDieParaname);
            dieBar?.EnableBar();
        }
    }
    private void Update()
    {
        TakeDame();
    }
}
