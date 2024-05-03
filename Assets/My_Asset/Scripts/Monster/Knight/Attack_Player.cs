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
    public bool attacking = false;
    private bool hit;
    private void Dame()
    {
        hit = Physics2D.OverlapCircle(swordPoint.position, rangeAttk, player);
        if (attacking == false)
        {
            if (hit)
            {
                animator.SetTrigger(isAttackParaname);
                isAttk = true;
            }
            if (isAttk == true)
            {
                character.TakeDame(dame);
                isAttk = false;
                attacking = true;
            }
        }
        //if (isAttk == true)
        //{
        //    character.TakeDame(dame);
        //    attacking = true;
        //    isAttk = false;
        //}
        if (!hit)
        {
            attacking = false;
        }
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(swordPoint.position,rangeAttk);
    }
    private void Update()
    {
        Dame();
    }
}
