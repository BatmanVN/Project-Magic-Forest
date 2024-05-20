using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] private GameObject fireObj;
    [SerializeField] private Rigidbody2D fireball2D;
    [SerializeField] private Vector2 speed;
    [SerializeField] private Animator fireballAnim;
    [SerializeField] private SpriteRenderer fireball;
    [SerializeField] private Knight_BeAttack beAttack;
    [SerializeField] private float disableTime;
    private void FireballFly()
    {
        var speedForce = speed;
        if (fireball.flipX == true)
        {
            speedForce *= -1;
        }
        fireball2D.velocity = speedForce;
        fireballAnim.SetTrigger("isFly");
        if(beAttack.BeAttack == false)
        {
            Color color = fireball.color;
            color.a -= disableTime *Time.deltaTime;
            fireball.color = color;
        }
    }
    private void Start()
    {
        Destroy(fireObj, fireball.color.a / disableTime);
    }
    private void Update()
    {
        FireballFly();
    }
}
