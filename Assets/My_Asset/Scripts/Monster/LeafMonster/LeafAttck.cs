using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class LeafAttck : MonoBehaviour
{
    [SerializeField] private Transform mouthLeaf;
    [SerializeField] private GameObject bulletLeaf;
    [SerializeField] private int delay;
    //[SerializeField] private LeanGameObjectPool bulletPool;
    private void Awake()
    {
        Leafattack();
    }
    private void Leafattack()
    {
        Instantiate(bulletLeaf, mouthLeaf.position, Quaternion.identity);
        //bulletPool.Spawn();
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
