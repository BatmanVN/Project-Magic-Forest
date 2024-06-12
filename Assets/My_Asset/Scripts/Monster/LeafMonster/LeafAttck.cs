using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafAttck : MonoBehaviour
{
    [SerializeField] private Transform mouthLeaf;
    [SerializeField] private GameObject bulletLeaf;
    [SerializeField] private int numberBullet;
    [SerializeField] private int delay;
    private void Awake()
    {
        Leafattack();
    }
    private void Leafattack()
    {
            Instantiate(bulletLeaf, mouthLeaf.position, Quaternion.identity);
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        Leafattack();
        yield return StartCoroutine(Delay());
    }
    private void Start()
    {
        StartCoroutine(Delay());
    }
}
