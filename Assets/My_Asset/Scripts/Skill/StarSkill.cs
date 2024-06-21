using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSkill : MonoBehaviour
{
    private const string hitParaname = "whenHit";
    [SerializeField] private string[] stopBullet = new string[] { "Ground", "StopGround", "StopGroundRight","KinghtMonster","SkeMonster", "PigFly", "FireMan" };
    [SerializeField] private Rigidbody2D starRig2d;
    [SerializeField] private Vector2 starDirection;
    [SerializeField] private SpriteRenderer starRenderer;
    [SerializeField] private Animator starAnimator;
    [SerializeField] private GameObject starPrefabs;
    [SerializeField] private float disableTime;
    private bool wasHit;
    private void OnTriggerEnter2D(Collider2D starSkill)
    {
        foreach(var tags in stopBullet)
        {
            if (starSkill.CompareTag(tags))
            {
                wasHit = true;
                starAnimator.SetTrigger(hitParaname);
                Color color = starRenderer.color;
                color.a -= disableTime * Time.deltaTime;
                starRenderer.color = color;
                StartCoroutine(Delay());
            }
        }
    }
    private void Destroy()
    {
        starPrefabs.SetActive(false);
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy();
    }
    private void StarMove()
    {
        var star = starDirection;
        if(starRenderer.flipX == true)
        {
            star *= -1;
        }
        if(wasHit == true)
        {
            star *= 0;
        }
        starRig2d.velocity = star;

    }
    private void Start()
    {
        
    }
    void Update()
    {
        StarMove();
    }
}
