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
    public void CheckUp()
    {
        isGrounded = Physics2D.OverlapCircle(canJump.position, 0.1f, ground);
        var jumpRection = jumpDirection;
        if(jumpLeft == 0)
        {
            return;
        }
        player2D.velocity = jumpRection;
        animator.SetTrigger("isJump");
        jumpLeft--;
        if(!isGrounded && jumpLeft > 0)
        {
            player2D.velocity = jumpDirection;
            jumpLeft--;
        }
    }
    private void RestJump()
    {
        if (isGrounded && jumpLeft == 0)
        {
            jumpLeft++;
            if(jumpLeft == maxJump)
            {
                return;
            }
        }
    }
    private void Update()
    {
        RestJump();
    }
}
