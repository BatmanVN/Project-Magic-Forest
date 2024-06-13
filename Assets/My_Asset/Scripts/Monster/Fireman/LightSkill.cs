using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSkill : MonoBehaviour
{
    private const string lightSkillParaname = "isFly";
    [SerializeField] private string[] stopBullet = new string[] { "Ground", "Player", "StopGround", "StopGroundRight" };
    [SerializeField] private Rigidbody2D lightRig;
    [SerializeField] private Vector2 speed;
    [SerializeField] private Animator lightAnim;
    [SerializeField] private GameObject lightSkillObj;
    [SerializeField] private SpriteRenderer lightSprite;
    [SerializeField] private float timeDisable;
    private bool wasHit;
    private void Attack()
    {
        var speedLight = speed;
        if (wasHit == true)
        {
            speedLight *= 0;
            Color bullet = lightSprite.color;
            bullet.a -= timeDisable * Time.deltaTime;
            lightSprite.color = bullet;
        }
        lightRig.velocity = speedLight;
        lightAnim.SetTrigger(lightSkillParaname);
    }
    private void OnTriggerEnter2D(Collider2D lightSkill)
    {
        foreach(var tags in stopBullet)
        {
            if(lightSkill.CompareTag(tags))
            {
                wasHit = true;
                StartCoroutine(Delay());
            }
        }
    }
    private void Destroybullet()
    {
        Destroy(lightSkillObj, lightSprite.color.a / timeDisable);
    }
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
        Destroybullet();
    }
    private void Update()
    {
        Attack();
    }
}
