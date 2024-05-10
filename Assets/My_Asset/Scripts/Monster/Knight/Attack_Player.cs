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
    [SerializeField] private float dameDefautl;
    [SerializeField] private float currentDame;
    [SerializeField] private HealthCharacter character;
    //[SerializeField] private Player_Move playerFlip;
    public bool isAttk;
    private void TakeDame() //Plan 1
    {
        var hit = Physics2D.OverlapCircle(swordPoint.position, rangeAttk, player);
        var scale = transform.localScale;
        if(isAttk == false)
        {
            if (hit)
            {
                //for (float angle = 0; angle < 90; angle++)
                //{
                //    float radiusLeft = angle * Mathf.Rad2Deg;
                //    float x = Mathf.Cos(radiusLeft) * rangeAttk;
                //    float y = Mathf.Sin(radiusLeft) * rangeAttk;
                //    scale.x = -(float)1.4f;
                //}
                //for (float angle = 90; angle < 180; angle++)
                //{
                //    float radiusRigt = angle * Mathf.Rad2Deg;
                //    float x = Mathf.Cos(radiusRigt) * rangeAttk;
                //    float y = Mathf.Sin(radiusRigt) * rangeAttk;
                //    scale.x = (float)1.4f;
                //}
                if (bonusDef.eatDef == false)
                {
                    currentDame = dameDefautl;
                }
                animator.SetTrigger(isAttackParaname);
                character.TakeDame(currentDame);
                transform.localScale = scale;
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
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(swordPoint.position, rangeAttk);
    }
}
