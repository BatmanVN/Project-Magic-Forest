using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player2D;
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private Animator animator;
    [SerializeField] private Vector2 moveDirection;

    private bool isLeft;
    private bool isRight;
    private bool isStop;
    public void MoveLeft()
    {
        isLeft = true;
        var direction = moveDirection;
        direction.y = player2D.velocity.y;
        if (isLeft == true)
        {
            playerSprite.flipX = true;
            direction *= -1;
        }
        player2D.velocity = direction;
    }
    public void MoveRight()
    {
        isRight = true;
        var direction = moveDirection;
        direction.y = player2D.velocity.y;
        if (isRight == true)
        {
            playerSprite.flipX = false;
            direction *=1;
        }
        player2D.velocity = direction;
    }
}
