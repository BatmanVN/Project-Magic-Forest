using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Controller : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> monsterComponents;
    [SerializeField] private AutoMove automove;
    [SerializeField] private Knight_BeAttack monsterBeAttk;
    [SerializeField] private HealthCharacter monsterHealth;
    [SerializeField] private Attack_Player attackPlayer;

    private void GetComponents()
    {
        monsterComponents.Add(automove);
        monsterComponents.Add(monsterBeAttk);
        monsterComponents.Add(monsterHealth);
        monsterComponents.Add(attackPlayer);
    }
}
