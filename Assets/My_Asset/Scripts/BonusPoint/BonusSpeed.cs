using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeed : MonoBehaviour
{
    [SerializeField] private GameObject speedObj;
    [SerializeField] private Player_BonusSPD bonusSPD;
    private void OnTriggerEnter2D(Collider2D bonusSpeed)
    {
        if(bonusSpeed.CompareTag("Player"))
        {
            bonusSPD?.SpeedUP();
            speedObj.SetActive(false);
        }
    }
}
