using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField] private string[] stopBullet = new string[] { "Ground", "StopGround", "StopGroundRight" };
    [SerializeField] private GameObject fireObj;
    [SerializeField] private Rigidbody2D fireball2D;
    [SerializeField] private Vector2 speed;
    [SerializeField] private Animator fireballAnim;
    [SerializeField] private SpriteRenderer fireball;
    [SerializeField] private Knight_BeAttack beAttack;
    [SerializeField] private float disableTime;
    private bool wasHit;
    private void FireballFly()
    {
        var speedForce = speed;
        if (fireball.flipX == true)
        {
            speedForce *= -1;
        }
        if(wasHit == true)
        {
            speedForce *= 0;
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
    private void OnTriggerEnter2D(Collider2D bullet)
    {
        foreach (var tags in stopBullet)
        {
            if (bullet.CompareTag(tags))
            {
                wasHit = true;
                fireballAnim.SetTrigger("whenHit");
                disableTime += 0.5f;
            }
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
