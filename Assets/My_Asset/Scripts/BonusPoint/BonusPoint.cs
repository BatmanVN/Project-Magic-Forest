using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;

public class BonusPoint : MonoBehaviour
{
    [SerializeField] private Jump_BonusPoint jumpBonus;
    [SerializeField] private GameObject PointBonus;
    [SerializeField] private float delay;
    public bool jumpEnabled;
    private void OnTriggerEnter2D(Collider2D bonusPoint)
    {
        if(bonusPoint.CompareTag("Player"))
        {
            jumpEnabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D bonusPoint)
    {
        if (bonusPoint.CompareTag("Player"))
        {
            jumpEnabled = false;
        }
    }
    private void DisAbleBonusPoint()
    {
        if(jumpBonus.isJumpBonus == true)   
        {
            Destroy(PointBonus);
        }
    }
    private void Start()
    {
        InvokeRepeating(nameof(DisAbleBonusPoint), delay, delay);
    }
}
