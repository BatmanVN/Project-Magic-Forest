using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeed : MonoBehaviour
{
    [SerializeField] private GameObject speedObj;
    [SerializeField] private GameObject effect;
    public bool speedUp;
    private void OnTriggerEnter2D(Collider2D bonusSpeed)
    {
        if(bonusSpeed.CompareTag("Player"))
        {
            speedUp = true;
            speedObj.SetActive(false);
            effect.SetActive(false);
        }
    }
}
