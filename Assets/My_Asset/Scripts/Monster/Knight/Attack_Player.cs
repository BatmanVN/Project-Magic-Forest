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
    [SerializeField] private float dame;
    [SerializeField] private HealthCharacter character;
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private Player_Move playerFlip;
    public float delay;
    public bool isAttk;
    private void Dame()
    {
        var hit = Physics2D.OverlapCircle(swordPoint.position, rangeAttk, player);
        var scale = enemyTransform.localScale;
        if (hit)
        {
            animator.SetTrigger(isAttackParaname);
            character.TakeDame(dame);
            isAttk = true;
            if(isAttk == false)
            {
                dame = 0;
            }
        }
    }
    private void DelayDame()
    {
        InvokeRepeating(nameof(Dame),delay,delay);
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(swordPoint.position,rangeAttk);
    }
    private void Start()
    {
        Dame();
        DelayDame();
    }
}
