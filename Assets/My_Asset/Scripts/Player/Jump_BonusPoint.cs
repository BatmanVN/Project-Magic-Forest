using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_BonusPoint : MonoBehaviour
{
    private const string jumpbonusParaname = "isBonus";
    [SerializeField] private BonusPoint jumpPoint;
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
            isJumpBonus = true;
            bonus *= 2;
            player2D.velocity = bonus;
            playerAnim.SetTrigger(jumpbonusParaname);
        }
        if (bonusPoint.jumpEnabled == false)
        {
            return;
        }
    }
    private void Update()
    {
        BonusPoint();
    }
}
