using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Attack_Player : MonoBehaviour
{
    private const string isAttackParaname = "isAttack";
    [SerializeField] private Transform swordPoint;
    [SerializeField] private Animator animator;
    [SerializeField] private float rangeAttk;
    [SerializeField] private LayerMask player;
    [SerializeField] public float dame;
    [SerializeField] private HealthCharacter character;
    public bool isAttk;
    public bool hasAttk;
    private void Dame()
    {
        var hit = Physics2D.OverlapCircle(swordPoint.position,rangeAttk,player);
        if (hit)
        {
            animator.SetBool(isAttackParaname,true);
            character.PlayerbeAttk(dame);
            isAttk = true;
            hasAttk = true;
        }
        else
        {
            animator.SetBool(isAttackParaname, false);
            isAttk = false;
        }
    }
    private void Update()
    {
        Dame();
    }
}
