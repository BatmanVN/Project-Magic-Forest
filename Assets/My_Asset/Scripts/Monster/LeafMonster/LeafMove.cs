using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafMove : MonoBehaviour
{
    [SerializeField] private string[] stopBullet = new string[] { "Ground", "Player", "StopGround", "StopGroundRight" };
    [SerializeField] private GameObject bulletLeaf;
    [SerializeField] private Rigidbody2D bulletRection;
    [SerializeField] private Vector2 speed;
    private void OnTriggerEnter2D(Collider2D leafBullet)
    {
        foreach(string tags in stopBullet)
        {
            if (leafBullet.CompareTag(tags))
            {
                Destroy(bulletLeaf);
            }
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
