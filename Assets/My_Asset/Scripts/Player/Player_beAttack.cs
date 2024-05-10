using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_beAttack : MonoBehaviour
{
    private const string beAttackParaname = "beAttack";
    [SerializeField] private HealthCharacter character;
    [SerializeField] private Player_BonusDef bonusDef;
    [SerializeField] private Animator playerAnim;
    [SerializeField] private Player_jump jump;
    [SerializeField] private float takeDame;
    [SerializeField] private float jumpRec;
    public bool beAttack;
    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.CompareTag("KinghtMonster"))
        {
            playerAnim.SetTrigger(beAttackParaname);
            jump?.JumpBeAttk(jumpRec);
            beAttack = true;
        }
    }
    private void TakeDame()
    {
        if(beAttack == true && bonusDef.enableEffect == false)
        {
            character?.TakeDame(takeDame);
        }
    }
    private void Update()
    {
        TakeDame();
    }
}
