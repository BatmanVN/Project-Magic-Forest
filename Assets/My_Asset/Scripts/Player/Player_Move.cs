using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    private const string isWalkingParaname = "isWalking";
    [SerializeField] private Run_Animation runAnim;
    [SerializeField] private Player_BonusSPD speedUp;
    [SerializeField] private Rigidbody2D player2D;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2 moveDirection;
    [SerializeField] private float speedDefault;
    [SerializeField] private Bool_Class boolRef;
    public bool isFlipKey;
    public bool isLeft;
    public bool isRight;
    public bool isStop;
    public bool stopGroundLeft;
    public bool stopGroundRight;
    public bool isFlip = false;
    public bool isRunning;

    public void EnableSpeedUP(float speedUp)
    {
        speedDefault += speedUp;
    }
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
                scale.x = -2;
                direction.x *= -speedDefault;
                
            }
            else
            {
                scale.x = 2;
                direction.x *= speedDefault;
            }
            transform.localScale = scale;
            player2D.velocity = direction;
            animator.SetBool(isWalkingParaname, true);
            isRunning = true;
        }
        runAnim?.EnableRunAnim();
    }
    private void KeyMove()
    {
        var keyWalking = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);
        var direction = moveDirection;
        direction.y = player2D.velocity.y;
        if (keyWalking)
        {
            isFlip = Input.GetKey(KeyCode.A) || isLeft == true;
            var scale = transform.localScale;
            if (isFlip)
            {
                scale.x = -2;
                direction.x *= -speedDefault;
            }
            else
            {
                scale.x = 2;
                direction.x *= speedDefault;
            }
            transform.localScale = scale;
            player2D.velocity = direction;
            animator.SetBool(isWalkingParaname, true);
            isRunning = true;
        }
        if(!keyWalking)
        {
            player2D.velocity = new Vector2(direction.x*0,direction.y);
            animator.SetBool(isWalkingParaname, false);
            isRunning = false;
        }
        runAnim?.EnableRunAnim();
    }
    public void Stopmove()
    {
        player2D.velocity = new Vector2(player2D.velocity.x * 0, player2D.velocity.y);
        animator.SetBool(isWalkingParaname, false);
        isStop = true;
        isRunning = false;
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
        KeyMove();
        PlayerMove();
    }
}
