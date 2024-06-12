using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafMove : MonoBehaviour
{
    [SerializeField] private GameObject bulletLeaf;
    [SerializeField] private Rigidbody2D bulletRection;
    [SerializeField] private Vector2 speed;
    private void OnTriggerEnter2D(Collider2D leafBullet)
    {
        if (leafBullet.CompareTag("Ground") || leafBullet.CompareTag("Player"))
        {
            Destroy(bulletLeaf);
        }
    }
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
