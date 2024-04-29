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

    public bool isLeft;
    public bool isRight;
    public bool isStop;
    public bool stopGroundLeft;
    public bool stopGroundRight;

    //public void MoveLeft()
    //{
    //    isLeft = true;
    //}
    //public void MoveRight()
    //{
    //    isRight = true;
    //}
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
        player2D.velocity = new Vector2(player2D.velocity.x * 0, player2D.velocity.y);
        animator.SetBool(isWalkingParaname, false);
        isStop = true;
    }
    private void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.CompareTag("StopGround"))
        {
            isLeft = false;
            stopGroundLeft = true;
        }
        if (Player.CompareTag("StopGroundRight"))
        {
            isRight = false;
            stopGroundRight = true;
        }
    }
    private void OnTriggerExit2D(Collider2D Player)
    {
        if (Player.CompareTag("StopGround"))
        {
            stopGroundLeft = false;
        }
        if (Player.CompareTag("StopGroundRight"))
        {
            stopGroundRight = false;
        }
    }
    public void DownLeft()
    {
        if (stopGroundLeft == false)
            isLeft = true;
    }
    public void DownRight()
    {
        if(stopGroundRight == false)
            isRight = true;
    }
    public void UpLeft()
    {
        isLeft = false;
        Stopmove();
    }
    public void UpRight()
    {
        isRight = false;
        Stopmove();
    }
    private void Update()
    {
        PlayerMove();
    }
    //private void Start()
    //{
    //    isLeft = false;
    //    isRight = false;
    //}
}
