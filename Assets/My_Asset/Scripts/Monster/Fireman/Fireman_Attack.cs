using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireman_Attack : MonoBehaviour
{
    [SerializeField] private GameObject bulletFire;
    [SerializeField] private Transform playPostion;
    [SerializeField] private Transform attackPostion;
    [SerializeField] private float rangeAttk;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private float dame;
    [SerializeField] private SpriteRenderer bulletSprite;
    [SerializeField] private float timeDelay;
    [SerializeField] private float dameSkill;

    private bool isEnemy;
    public float Dame { get => dame; private set => dame = value; }
    public bool IsEnemy { get => isEnemy; set => isEnemy = value; }
    public float DameSkill { get => dameSkill; set => dameSkill = value; }

    private void AttackPlayer()
    {
        var scale = transform.localScale;
        var fireManPostion = transform.position;
        var hit = Physics2D.OverlapCircle(attackPostion.position, rangeAttk, playerMask);
        if (hit)
        {
            IsEnemy = true;
        }
        else
        {
            IsEnemy = false;
        }
        if (fireManPostion.x > playPostion.transform.position.x)
        {
            scale.x = (float)2.5f;
            bulletSprite.flipX = true;
        }
        else if (fireManPostion.x < playPostion.transform.position.x)
        {
            scale.x = -(float)2.5f;
            bulletSprite.flipX = false;
        }
        transform.localScale = scale;
    }
    private void AttackPlay()
    {
        if(isEnemy == true)
        {
            Instantiate(bulletFire, attackPostion.position, Quaternion.identity);
        }
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(timeDelay);
        AttackPlay();
        yield return StartCoroutine(Delay());
    }
    private void Update()
    {
        AttackPlayer();
    }
    private void Start()
    {
        StartCoroutine(Delay());
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(attackPostion.position, rangeAttk);
    }
}
