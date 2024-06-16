using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    [SerializeField] private string speedKey;
    [SerializeField] private AudioSource walkAudio;
    private const string isWalkingParaname = "isWalking";
    [SerializeField] private Run_Animation runAnim;
    [SerializeField] private Player_BonusSPD speedUp;
    [SerializeField] private Rigidbody2D player2D;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2 moveDirection;
    [SerializeField] private float speedDefault;
    [SerializeField] private StopGround stopGround;

    private bool isLeft;
    private bool isRight;
    private bool isFlip = false;
    public bool isRunning;

    public bool IsLeft { get => isLeft; set => isLeft = value; }
    public bool IsRight { get => isRight; set => isRight = value; }
    public bool IsFlip { get => isFlip; set => isFlip = value; }
    public string SpeedKey { get => speedKey; set => speedKey = value; }

    [ContextMenu("GetSpeed")]
    public void EnableSpeedUP(float speed)
    {
        speedDefault += speed;
    }
    private void PlayerMove()
    {
        var direction = moveDirection * Time.deltaTime;
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
        var direction = moveDirection * Time.deltaTime;
        direction.y = player2D.velocity.y;
        if (keyWalking)
        {
            IsFlip = Input.GetKey(KeyCode.A) || isLeft == true;
            var scale = transform.localScale;
            if (IsFlip)
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
        isRunning = false;
    }
    public void DownLeft()
    {
        if (stopGround.StopGroundLeft == false)
           isLeft = true;
        walkAudio.Play();
    }
    public void DownRight()
    {
        if(stopGround.StopGroundRight == false)
            isRight = true;
        
        walkAudio.Play();
    }
    public void UpLeft()
    {
        isLeft = false;
        Stopmove();
        walkAudio.Pause();
    }
    public void UpRight()
    {
        isRight = false;
        Stopmove();
        walkAudio.Pause();
    }
    private void Update()
    {
        Debug.Log(isLeft);
        Debug.Log(isRight);
        KeyMove();
        PlayerMove();
    }
    private void GetSpeed()
    {
        speedDefault = PlayerPrefs.GetFloat(SpeedKey, speedDefault);
    }
    private void Start()
    {
        GetSpeed();
    }
}
