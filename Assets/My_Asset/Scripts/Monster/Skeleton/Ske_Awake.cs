using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ske_Awake : MonoBehaviour
{
    private const string awakeParaname = "skeWake";
    private const string sleepParaname = "skeSleep";
    [SerializeField] private SkeAuto_Move skeMove;
    [SerializeField] private Animator skeAnim;
    [SerializeField] private float rangeAtk;
    [SerializeField] private Transform skeLeton;
    [SerializeField] private LayerMask player;
    [SerializeField] private Transform point;
    private void SkeAwake()
    {
        var skeAwake = Physics2D.OverlapCircle(skeLeton.position, rangeAtk,player);
        var skeawake = Physics2D.OverlapCircle(point.position, rangeAtk, player);
        if (skeAwake || skeawake)
        {
            skeAnim.SetTrigger(awakeParaname);
            skeMove.enabled = true;
        }
        if(!skeAwake && !skeawake)
        {
            skeAnim.SetTrigger(sleepParaname);
            skeMove.enabled = false;
        }
    }
    private void Update()
    {
        SkeAwake();
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(skeLeton.position, rangeAtk);
    }
}
