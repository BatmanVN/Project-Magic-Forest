using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ske_controller : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> skeComponents;
    [SerializeField] private HealthCharacter skeHealth;

    public bool Active = false;

    private void Start()
    {
        StartBattle();
    }
    private void StartBattle()
    {
        Active = true;
        EnableComponents();
    }
    private void EndBattle()
    {
        Active = false;
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
    private void SetActiveComponents(bool isActive)
    {
        foreach (var component in skeComponents)
        {
            component.enabled = isActive;
        }
    }

    private void Update()
    {
        if(!Active)
        {
            return;
        }
        if(skeHealth.isDead)
        {
            EndBattle();
        }
    }
}
