using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireman_Attack : MonoBehaviour
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
        var fireManPostion = transform.position;
        var hit = Physics2D.OverlapCircle(attackPostion.position, rangeAttk, playerMask);
        if (isAttk == false)
        {
            if (hit)
            {
                isAttk = true;
                IsEnemy = true;
            }
        }
        else if (!hit)
        {
            isAttk = false;
        }
        if (fireManPostion.x > playPostion.transform.position.x)
        {
            scale.x = (float)2;
        }
        else if (fireManPostion.x < playPostion.transform.position.x)
        {
            scale.x = -(float)2;
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
