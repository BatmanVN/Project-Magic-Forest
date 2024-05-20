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
    [SerializeField] private float delay;
    private bool isAnim;
    private void OnTriggerEnter2D(Collider2D starSkill)
    {
        if(starSkill.CompareTag("KinghtMonster"))
        {
            starAnimator.SetTrigger(hitParaname);
            isAnim = true;
        }
    }
    private void Destroy()
    {
        if(isAnim)
        {
            Destroy(starPrefabs);
        }
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
        InvokeRepeating(nameof(Destroy), delay, 0);
    }
    void Update()
    {
        StarMove();
    }
}
