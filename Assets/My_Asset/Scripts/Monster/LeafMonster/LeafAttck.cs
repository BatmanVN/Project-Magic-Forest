using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafAttck : MonoBehaviour
{
    [SerializeField] private Transform mouthLeaf;
    [SerializeField] private GameObject bulletLeaf;
    [SerializeField] private int numberBullet;
    [SerializeField] private int delay;
    private void OnTriggerEnter2D(Collider2D leafBullet)
    {
        if (leafBullet.CompareTag("Ground") || leafBullet.CompareTag("Player"))
        {
            Destroy(bulletLeaf);
        }
    }
    private void Leafattack()
    {
        if(numberBullet <= 5)
        {
            Instantiate(bulletLeaf, mouthLeaf.position, Quaternion.identity);
            numberBullet += 1;
        }
        if(numberBullet >= 5)
        {
            numberBullet = 0;
        }
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        Leafattack();
        StartCoroutine(Delay());
    }
    private void Update()
    {
        StartCoroutine(Delay());
    }
}
