using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Attack_Player : MonoBehaviour
{   //Plan 1
    private const string isAttackParaname = "isAttack";
    [SerializeField] private Transform swordPoint;
    [SerializeField] private float rangeAttk;
    [SerializeField] private LayerMask player;
    [SerializeField] private Transform enemyTransform;
    [SerializeField] private Animator animator;
    [SerializeField] private float monsterDame;
    public float DameKnight { get => monsterDame; private set => monsterDame = value; }
    public bool IsAttk { get => isAttk; set => isAttk = value; }
    public bool IsEnemy { get => isEnemy; set => isEnemy = value; }

    private bool isAttk;
    private bool isEnemy;

    private void TakeDame() //Plan 1
    {
        var hit = Physics2D.OverlapCircle(swordPoint.position, rangeAttk, player);
        var scale = transform.position;
        var localScale = transform.localScale;
        if (IsAttk == false)
        {
            if (hit)
            {
                if (scale.x > enemyTransform.transform.position.x) // khi nhan vat o ben trai //Lon trai
                {
                    localScale.x = (float)-1.4f;
                }
                else if (scale.x < enemyTransform.transform.position.x) // khi nhan vat o ben phai //Nho Phai
                {
                    localScale.x = (float)1.4f;
                }
                animator.SetTrigger(isAttackParaname);
                transform.localScale = localScale;
                IsAttk = true;
                IsEnemy = true;
            }
        }
        if (!hit)
        {
            IsAttk = false;
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
