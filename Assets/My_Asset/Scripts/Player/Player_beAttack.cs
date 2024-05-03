using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_beAttack : MonoBehaviour
{
    private const string beAttackParaname = "beAttack";
    [SerializeField] private HealthCharacter character;
    [SerializeField] private Attack_Player attacker;
    [SerializeField] private Animator playerAnim;
    //private float takeDame;
    private void BeAttack()
    {
        if(attacker.isAttk == true)
        {
            playerAnim.SetTrigger(beAttackParaname);
        }
    }
    private void Update()
    {
        BeAttack();
    }
}
