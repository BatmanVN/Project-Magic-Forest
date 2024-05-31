using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ske_Awake : MonoBehaviour
{
    private const string awakeParaname = "skeWake";
    [SerializeField] private GameObject groundBoss;
    [SerializeField] private SkeAuto_Move skeMove;
    [SerializeField] private Animator skeAnim;
    [SerializeField] private float rangeAtk;
    [SerializeField] private Transform skeLeton;
    [SerializeField] private LayerMask player;
    [SerializeField] private GameObject skeHealthBar;
    [SerializeField] private HealthCharacter skeHealth;
    [SerializeField] private Rigidbody2D skeBody;
    private void SkeAwake()
    {
        var skeAwake = Physics2D.OverlapCircle(skeLeton.position, rangeAtk, player);

        if (skeAwake)
        {
            skeAnim.SetTrigger(awakeParaname);
            skeBody.gravityScale = 1f;
            skeHealthBar.SetActive(true);
            skeMove.enabled = true;
            groundBoss.SetActive(true);
        }
        if(skeHealth.isDead)
        {
            groundBoss.SetActive(false);
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
