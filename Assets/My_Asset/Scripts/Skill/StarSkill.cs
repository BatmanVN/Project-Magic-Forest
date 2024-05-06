using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSkill : MonoBehaviour
{
    [SerializeField] private Rigidbody2D starRig2d;
    [SerializeField] private Vector2 starDirection;
    [SerializeField] private SpriteRenderer starRenderer;
    private void StarMove()
    {
        var star = starDirection;
        if(starRenderer.flipX == true)
        {
            star *= -1;
        }
        starRig2d.velocity = star;

    }
    void Update()
    {
        StarMove();
    }
}
