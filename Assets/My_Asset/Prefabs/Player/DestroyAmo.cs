using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAmo : MonoBehaviour
{
    [SerializeField] private GameObject bulletObj;
    [SerializeField] private GameObject destroyAmo;
    [SerializeField] private Animator destroyBullet;
    //[SerializeField] private DestroyBullet hit;
    private bool wasHit;

    public bool WasHit { get => wasHit; set => wasHit = value; }

    private void OnTriggerEnter2D(Collider2D bullet)
    {
        if(bullet.CompareTag("Ground"))
        {
            wasHit = true;
            bulletObj.SetActive(false);
            Instantiate(destroyAmo, bulletObj.transform.position, Quaternion.identity);
            destroyBullet.SetTrigger("isDestroy");
        }
    }
    private void Start()
    {
        
    }
}
