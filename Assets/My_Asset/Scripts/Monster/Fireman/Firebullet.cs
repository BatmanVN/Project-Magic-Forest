using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebullet : MonoBehaviour
{
    private const string flyBulletName = "isFly";
    private const string destroyBulletName = "isDestroy";
    [SerializeField] private string[] stopBullet = new string[] { "Ground","Player", "StopGround", "StopGroundRight" };
    [SerializeField] private Rigidbody2D bullet;
    [SerializeField] private GameObject firebulletObj;
    [SerializeField] private Animator bulletAnim;
    [SerializeField] private Vector2 speed;
    [SerializeField] private SpriteRenderer bulletSprite;
    [SerializeField] private float disableTime;
    private bool wasHit;
    private void FiretheBullet()
    {
        var speedForce = speed;
        if (bulletSprite.flipX == true)
        {
            speedForce *= -1;
        }
        else
            speed *= 1;
        if(wasHit == true)
        {
            speedForce *= 0;
            Color bullet = bulletSprite.color;
            bullet.a -= disableTime * Time.deltaTime;
            bulletSprite.color = bullet;
        }
        bullet.velocity = speedForce;
        bulletAnim.SetTrigger(flyBulletName);  
    }
    private void OnTriggerEnter2D(Collider2D bullet)
    {
        foreach(string tagstoCompare in stopBullet)
        {
            if (bullet.CompareTag(tagstoCompare))
            {
                wasHit = true;
                bulletAnim.SetTrigger(destroyBulletName);
                StartCoroutine(Delay());
            }
        }
    }
    private void Destroybullet()
    {
            Destroy(firebulletObj, bulletSprite.color.a / disableTime);
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        Destroybullet();
    }
    private void Update()
    {
        FiretheBullet();
    }
}
