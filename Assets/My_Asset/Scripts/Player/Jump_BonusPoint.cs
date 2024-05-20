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
    private bool isJumpBonus;

    public bool IsJumpBonus { get => isJumpBonus; set => isJumpBonus = value; }

    private void BonusPoint()
    {
        var bonus = jumpBonusPoint;
        if (bonusPoint.JumpEnabled == true)
        {
            bonus *= 2;
            player2D.velocity = bonus;
            playerAnim.SetTrigger(jumpbonusParaname);
            IsJumpBonus = true;
            Destroy(PointBonus);
            bonusPoint.JumpEnabled = false;
        }
        if (bonusPoint.JumpEnabled == false)
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
