using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDef : MonoBehaviour
{
    [SerializeField] private GameObject defObj;
    [SerializeField] private GameObject effect;
    [SerializeField] private Player_BonusDef bonusDef;
    private void OnTriggerEnter2D(Collider2D bonusSpeed)
    {
        if (bonusSpeed.CompareTag("Player"))
        {
            defObj.SetActive(false);
            effect.SetActive(false);
            bonusDef?.BonusDEF();
        }
    }
}
