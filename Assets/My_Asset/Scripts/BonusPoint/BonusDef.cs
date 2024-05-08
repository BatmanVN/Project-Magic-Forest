using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusDef : MonoBehaviour
{
    [SerializeField] private GameObject defObj;
    public bool eatDef;
    private void OnTriggerEnter2D(Collider2D bonusSpeed)
    {
        if (bonusSpeed.CompareTag("Player"))
        {
            eatDef = true;
            defObj.SetActive(false);
        }
    }
}
