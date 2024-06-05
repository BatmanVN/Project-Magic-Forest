using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Controller : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> monsterComponents;
    [SerializeField] private Health monsterHealth;
    private bool isAlive = false;

    private void Start()
    {
        StartBattle();
    }
    private void StartBattle()
    {
        isAlive = true;
        EnableComponents();
    }
    private void EndBattle()
    {
        isAlive = false;
        DisableComponents();
    }
    private void EnableComponents()
    {
        SetActiveComponents(true);
    }
    private void DisableComponents()
    {
        SetActiveComponents(false);
    }
    private void SetActiveComponents(bool active)
    {
        foreach (var component in monsterComponents)
        {
            component.enabled = active;
        }
    }
    private void Update()
    {
        if(!isAlive)
        {
            return;
        }
        if(monsterHealth.isDead)
        {
            EndBattle();
        }
    }
}
