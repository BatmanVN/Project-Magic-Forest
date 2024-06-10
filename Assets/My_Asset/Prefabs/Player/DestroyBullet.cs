using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    [SerializeField] private DestroyAmo[] hit;
    [SerializeField] private GameObject destroyAmo;
    [SerializeField] private float delay;
    private void DisableDestroy()
    {
        for(int i = 0; i < hit.Length; i++)
        {
            if (hit[i].WasHit == true)
            {
                Destroy(destroyAmo);
                Debug.Log(hit);
            }
        }
    }
    private void Update()
    {
        
    }
}
