using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour
{
    [SerializeField] private GameObject fireBall;
    [SerializeField] private Transform fireBallRight;
    [SerializeField] private Player_Move move;
    [SerializeField] private SpriteRenderer fireRender;
    public float dame;
    public void Attack()
    {
        if (move.isFlip == true)
        {
            fireRender.flipX = true;
        }
        if (move.isFlip == false)
        {
            fireRender.flipX = false;
        }
        Instantiate(fireBall, fireBallRight.position, Quaternion.identity);
    }
    private void Update()
    {
        
    }
}
