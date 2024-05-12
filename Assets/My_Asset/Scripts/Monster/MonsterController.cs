using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> monsterComponents;
    [SerializeField] private AutoMove automove;
    [SerializeField] private Knight_BeAttack monsterBeAttk;
    [SerializeField] private HealthCharacter monsterHealth;
    [SerializeField] private Attack_Player attackPlayer;

    private void GetComponents()
    {
        monsterComponents = new List<MonoBehaviour>
        {
            monsterBeAttk,
            monsterHealth,
            attackPlayer,
            attackPlayer
        };
        //monsterComponents.Add(automove);
        //monsterComponents.Add(monsterBeAttk);
        //monsterComponents.Add(monsterHealth);
        //monsterComponents.Add(attackPlayer);
    }
}
