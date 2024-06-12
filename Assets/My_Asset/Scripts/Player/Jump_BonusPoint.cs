using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_BonusPoint : MonoBehaviour
{
    private const string jumpbonusParaname = "isBonus";
    [SerializeField] private AudioSource bonusSound;
    [SerializeField] private GameObject PointBonus;
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
            bonusSound.Play();
            playerAnim.SetTrigger(jumpbonusParaname);
            IsJumpBonus = true;
            Destroy(PointBonus);
            bonusPoint.JumpEnabled = false;
        }
        if (bonusPoint.JumpEnabled == false)
        {
            return;
        }
    }
    private void Update()
    {
        BonusPoint();
    }
}
