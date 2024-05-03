using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    private const string isWalkingParaname = "isWalking";
    [SerializeField] private Rigidbody2D player2D;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2 moveDirection;

    public bool isLeft;
    public bool isRight;
    public bool isStop;
    public bool stopGroundLeft;
    public bool stopGroundRight;
    public bool isFlip = false;
    private void PlayerMove()
    {
        var direction = moveDirection;
        direction.y = player2D.velocity.y;
        var isWalking = isLeft == true || isRight == true;
        if (isWalking)
        {
            var scale = transform.localScale;
            isFlip = isLeft == true;
            if (isFlip)
            {
                direction.x *= -1;
                scale.x = -2;
            }
            else
            {
                scale.x = 2;
            }
            transform.localScale = scale;
            player2D.velocity = direction;
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
}
