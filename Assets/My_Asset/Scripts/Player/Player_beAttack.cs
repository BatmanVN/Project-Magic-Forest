using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_beAttack : MonoBehaviour
{
    private const string beAttackParaname = "beAttack";
    [SerializeField] private HealthCharacter character;
    [SerializeField] private Animator playerAnim;
    [SerializeField] private float jumpRec;
    public float JumpRec { get => jumpRec; private set => jumpRec = value; }
    public bool beAttack;
    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.CompareTag("KinghtMonster"))
        {
            playerAnim.SetTrigger(beAttackParaname);
            beAttack = true;
        }
    }
}
