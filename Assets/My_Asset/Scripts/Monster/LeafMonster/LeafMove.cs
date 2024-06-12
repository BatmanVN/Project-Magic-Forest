using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafMove : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bulletRection;
    [SerializeField] private Vector2 speed;
    private void BulletMove()
    {
        var speedBullet = speed;
        bulletRection.velocity = speed;
    }
    void Update()
    {
        BulletMove();
    }
}
