using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ske_attack : MonoBehaviour
{
    [SerializeField] private Transform playPostion;
    [SerializeField] private Transform attackPostion;
    [SerializeField] private float rangeAttk;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private float dame;
    private bool isAttk;
    private bool isEnemy;
    public float Dame { get => dame; private set => dame = value; }
    public bool IsEnemy { get => isEnemy; set => isEnemy = value; }

    private void AttackPlayer()
    {
        var scale = transform.localScale;
        var skePostion = transform.position;
        var hit = Physics2D.OverlapCircle(attackPostion.position, rangeAttk, playerMask);
        if(isAttk == false)
        {
            if (hit)
            {
                isAttk = true;
                IsEnemy = true;
            }
        }
        else if(!hit)
        {
            isAttk = false;
        }
        if (skePostion.x > playPostion.transform.position.x)
        {
            scale.x = -(float)2;
        }
        else if (skePostion.x < playPostion.transform.position.x)
        {
            scale.x = (float)2;
        }
        transform.localScale = scale;
    }
    private void Update()
    {
        AttackPlayer();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackPostion.position, rangeAttk);       
    }
}
