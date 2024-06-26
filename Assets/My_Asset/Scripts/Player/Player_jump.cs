using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_jump : MonoBehaviour
{
    [SerializeField] private AudioSource jumpKit;
    [SerializeField] private Player_beAttack beAttack;
    [SerializeField] private Player_Move moveComponent;
    [SerializeField] private Rigidbody2D player2D;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2 jumpDirection;
    [SerializeField] private Transform canJump;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float maxJump;
    [SerializeField] private float maxJumpDouble;
    [SerializeField] private float jumpLeft;
    private bool isGroundDouble;
    private bool isGrounded;
    private bool isJumping;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Canjump"))
        {
            isGroundDouble = true;
            moveComponent.IsRight = false;
            moveComponent.IsLeft = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Canjump"))
        {
            isGroundDouble = false;
        }
    }
    public void JumpBeAttk(float jump)
    {
            player2D.velocity = jumpDirection;
    }
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
        jumpKit.Play();
        animator.SetTrigger("isJump");
        jumpLeft--;
        if(!isGrounded && jumpLeft > 0)
        {
            if(isGroundDouble == false)
            {
                jumpLeft = maxJump;
                maxJumpDouble = 0;
            }
            //player2D.AddForce(jumpRection);
            player2D.velocity = jumpRection;
            jumpLeft--;
        }
        isJumping = true;
    }
    private void KeyJump()
    {
        var keyUp = Input.GetKeyDown(KeyCode.Space);
        isGrounded = Physics2D.OverlapCircle(canJump.position, 0.1f, ground);
        var jumpRection = jumpDirection;
        if (keyUp)
        {
            if (jumpLeft == 0)
            {
                return;
            }
            //player2D.AddForce(jumpRection);
            player2D.velocity = jumpRection;
            animator.SetTrigger("isJump");
            jumpLeft--;
            if (!isGrounded && jumpLeft > 0)
            {
                if (isGroundDouble == false)
                {
                    jumpLeft = maxJump;
                    maxJumpDouble = 0;
                }
                //player2D.AddForce(jumpRection);
                player2D.velocity = jumpRection;
                jumpLeft--;
                //animator.SetTrigger("notJump");
            }
            isJumping = true;
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
        if (isGroundDouble == true && isJumping == true)
        {
            jumpLeft = maxJumpDouble + 1;
        } 
    }
    private void Update()
    {
        KeyJump();
        RestJump();
    }
    
}
