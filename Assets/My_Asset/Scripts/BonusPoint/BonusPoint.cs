using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BonusPoint : MonoBehaviour
{
    [SerializeField] private Jump_BonusPoint jumpBonus;
    [SerializeField] private GameObject PointBonus;

    public bool jumpEnabled;
    private void OnTriggerEnter2D(Collider2D bonusPoint)
    {
        if(bonusPoint.CompareTag("Player"))
        {
            jumpEnabled = true;
        }
    }
}
