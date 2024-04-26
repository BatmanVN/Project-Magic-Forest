using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public string isWalkingParaname = "isWalking";
    [SerializeField] private Rigidbody2D player2D;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2 moveDirection;

    private bool isLeft;
    private bool isRight;
    public void MoveLeft()
    {
        isLeft = true;
    }
    public void MoveRight()
    {
        isRight = true;
    }
    private void PlayerMove()
    {
        var direction = moveDirection;
        //direction.y = player2D.velocity.y;
        if (isLeft == true)
        {
            direction.y = player2D.velocity.y;
            playerSprite.flipX = true;
            direction *= -1;
            player2D.velocity = direction;
            animator.SetBool(isWalkingParaname, true);
        }
        if (isRight == true)
        {
            direction.y = player2D.velocity.y;
            playerSprite.flipX = false;
            direction *= 1;
            player2D.velocity = direction;
            animator.SetBool(isWalkingParaname, true);
        }
    }
    public void Stopmove()
    {
        isLeft = false;
        isRight = false;
        player2D.velocity = new Vector2(player2D.velocity.x * 0, player2D.velocity.y);
        animator.SetBool(isWalkingParaname,false);
    }
    public void DownLeft()
    {
        isLeft = true;
    }
    public void DownRight()
    {
        isRight = true;
    }
    private void Update()
    {
        PlayerMove();
    }
    private void Start()
    {
        isLeft = false;
        isRight = false;
    }
}
