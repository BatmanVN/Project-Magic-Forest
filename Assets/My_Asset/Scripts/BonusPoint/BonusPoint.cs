using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BonusPoint : MonoBehaviour
{
    [SerializeField] private Jump_BonusPoint jumpBonus;

    private bool jumpEnabled;

    public bool JumpEnabled { get => jumpEnabled; set => jumpEnabled = value; }

    private void OnTriggerEnter2D(Collider2D bonusPoint)
    {
        if(bonusPoint.CompareTag("Player"))
        {
            JumpEnabled = true;
        }
    }
}
