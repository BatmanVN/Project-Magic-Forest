using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_BonusPoint : MonoBehaviour
{
    [SerializeField] private GameObject PointBonus;
    private const string jumpbonusParaname = "isBonus";
    [SerializeField] private Vector2 jumpBonusPoint;
    [SerializeField] private Rigidbody2D player2D;
    [SerializeField] private BonusPoint bonusPoint;
    [SerializeField] private Animator playerAnim;
    public bool isJumpBonus;
    private void BonusPoint()
    {
        var bonus = jumpBonusPoint;
        if (bonusPoint.jumpEnabled == true)
        {
            bonus *= 2;
            player2D.velocity = bonus;
            playerAnim.SetTrigger(jumpbonusParaname);
            isJumpBonus = true;
            Destroy(PointBonus);
            bonusPoint.jumpEnabled = false;
        }
        if (bonusPoint.jumpEnabled == false)
        {
            return;
        }
        //if(isJumpBonus == true)
        //{
        //    Destroy(PointBonus);
        //}
    }
    private void Update()
    {
        BonusPoint();
    }
}
