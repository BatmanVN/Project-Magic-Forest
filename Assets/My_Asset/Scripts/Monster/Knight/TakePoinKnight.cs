using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePoinKnight : MonoBehaviour
{
    [SerializeField] private HealthCharacter knightHealth;
    [SerializeField] private int killKnight;

    public int KillKnight { get => killKnight; set => killKnight = value; }

    private void EarnPoint()
    {
        if(knightHealth.isDead)
        {
            KillKnight += 1;
        }
    }
    private void Update()
    {
        EarnPoint();
    }
}
