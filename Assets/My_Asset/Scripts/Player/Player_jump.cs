using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_jump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player2D;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2 jumpDirection;
    [SerializeField] private Transform canJump;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float maxJump;
    [SerializeField] private float jumpLeft;
    bool isGrounded;

    private void Start()
    {
        jumpLeft = maxJump;
    }
    //public void CheckUp()
    //{
    //    isGrounded = Physics2D.OverlapCircle(canJump.position,0.1f,ground);
    //    var jumpRection = jumpDirection;
    //    if(isGrounded)
    //    {
    //        player2D.velocity = jumpRection;
    //        jumpLeft--;
    //        if(jumpLeft > 0)
    //        {
    //            player2D.velocity = jumpRection;
    //            jumpLeft--;
    //            if (isGrounded)
    //            {
    //                jumpLeft = maxJump;
    //            }
    //        }
    //    }
    //}
    public void CheckUp()
    {
        isGrounded = Physics2D.OverlapCircle(canJump.position,0.1f,ground);
        var jumpRection = jumpDirection;
        if(isGrounded || jumpLeft>0)
        {
            player2D.velocity = jumpRection;
            jumpLeft--;
            if(isGrounded)
            {
                jumpLeft = maxJump;
            }
        }
        if(jumpLeft == 1)
        {
            animator.SetTrigger("isJump");
        }
    }
}
