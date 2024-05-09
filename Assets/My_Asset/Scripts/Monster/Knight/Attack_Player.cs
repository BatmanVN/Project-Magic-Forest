using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Attack_Player : MonoBehaviour
{   //Plan 1
    [SerializeField] private Transform swordPoint;
    [SerializeField] private float rangeAttk;
    [SerializeField] private LayerMask player;
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private BonusDef bonusDef;

    private const string isAttackParaname = "isAttack";
    [SerializeField] private Animator animator;
    [SerializeField] private float dame;
    [SerializeField] private HealthCharacter character;
    //[SerializeField] private Player_Move playerFlip;
    public float delay;
    public bool isAttk;
    public float Dame { get => dame; private set => dame = value; }
    private void TakeDame() //Plan 1
    {
        var hit = Physics2D.OverlapCircle(swordPoint.position, rangeAttk, player);
        var scale = enemyTransform.localScale;
        if(isAttk == false)
        {
            if (hit)
            {
                if(bonusDef.eatDef == true)
                {
                    Dame = 0;
                }
                else if(bonusDef.eatDef == false)
                {
                    Dame = 3;
                }
                animator.SetTrigger(isAttackParaname);
                character.TakeDame(Dame);
                isAttk = true;
            }
        }
        if (!hit)
        {
            isAttk = false;
        }
    }
    //private void OnTriggerEnter2D(Collider2D Monster) //Plan 2
    //{
    //    if (Monster.CompareTag("Player"))
    //    {
    //        isAttk = true;
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D Monster)
    //{
    //    if (Monster.CompareTag("Player"))
    //    {
    //        isAttk = false;
    //    }
    //}
    //private void Takedame()
    //{
    //    if(isAttk == true)
    //    {
    //        animator.SetTrigger(isAttackParaname);
    //        character.TakeDame(Dame);
    //        isAttk = false;
    //    }
    //}
    private void Update()
    {
        TakeDame();
    }
    //public void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(swordPoint.position, rangeAttk);
    //}
}
