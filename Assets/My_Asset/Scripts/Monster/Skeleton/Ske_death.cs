using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ske_death : MonoBehaviour
{
    [SerializeField] private Health skeHealth;
    [SerializeField] private GameObject disableObj;
    private void Death()
    {
        if(skeHealth.isDead)
        {
            disableObj.SetActive(false);
        }
    }
    private void Update()
    {
        Death();
    }
}
