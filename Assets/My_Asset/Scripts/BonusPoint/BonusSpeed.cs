using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeed : MonoBehaviour
{
    [SerializeField] private GameObject speedObj;
    [SerializeField] private GameObject effect;
    [SerializeField] private Player_BonusSPD bonusSPD; 

    private void OnTriggerEnter2D(Collider2D bonusSpeed)
    {
        if(bonusSpeed.CompareTag("Player"))
        {
            speedObj.SetActive(false);
            effect.SetActive(false);
            bonusSPD?.EnableEffect();
        }
    }
}
