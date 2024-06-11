using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSkill : MonoBehaviour
{
    private const string hitParaname = "whenHit";
    [SerializeField] private Rigidbody2D starRig2d;
    [SerializeField] private Vector2 starDirection;
    [SerializeField] private SpriteRenderer starRenderer;
    [SerializeField] private Animator starAnimator;
    [SerializeField] private GameObject starPrefabs;
    [SerializeField] private float disableTime;
    private void OnTriggerEnter2D(Collider2D starSkill)
    {
        if(starSkill.CompareTag("KinghtMonster")|| starSkill.CompareTag("Ground") 
            || starSkill.CompareTag("StopGround") || starSkill.CompareTag("StopGroundRight"))
        {
            starAnimator.SetTrigger(hitParaname);
            Color color = starRenderer.color;
            color.a -= disableTime * Time.deltaTime;
            starRenderer.color = color;
            StartCoroutine(Delay());
        }
    }
    private void Destroy()
    {

        starPrefabs.SetActive(false);
        starRig2d.velocity = Vector2.zero;
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.7f);
        Destroy();
    }
    private void StarMove()
    {
        var star = starDirection;
        if(starRenderer.flipX == true)
        {
            star *= -1;
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
