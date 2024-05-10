using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Attack_Player : MonoBehaviour
{   //Plan 1
    private const string isAttackParaname = "isAttack";
    [SerializeField] private Transform swordPoint;
    [SerializeField] private float rangeAttk;
    [SerializeField] private LayerMask player;
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private Animator animator;
    [SerializeField] private float takeDame;
    //[SerializeField] private Player_Move playerFlip;
    public bool isAttk;
    public bool isEnemy;

    private void TakeDame() //Plan 1
    {
        var hit = Physics2D.OverlapCircle(swordPoint.position, rangeAttk, player);
        var scale = transform.localScale;
        if(isAttk == false)
        {
            if (hit)
            {
            //{
            //    for (float angle = 0; angle < 90; angle++)
            //    {
            //        float radiusLeft = angle * Mathf.Rad2Deg;
            //        float x = Mathf.Cos(radiusLeft) * rangeAttk;
            //        float y = Mathf.Sin(radiusLeft) * rangeAttk;
            //       isEnemy = true;
            //    }
            //    for (float angle = 90; angle < 180; angle++)
            //    {
            //        float radiusRigt = angle * Mathf.Rad2Deg;
            //        float x = Mathf.Cos(radiusRigt) * rangeAttk;
            //        float y = Mathf.Sin(radiusRigt) * rangeAttk;
            //        isEnemy = false;
            //    }
                animator.SetTrigger(isAttackParaname);
                transform.localScale = scale;
                isAttk = true;
            }
        }
        if (!hit)
        {
            isAttk = false;
        }
    }
    private void Update()
    {
        TakeDame();
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(swordPoint.position, rangeAttk);
    }
}
