using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireman_controller : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> controller;
    [SerializeField] private Health fireManHealth;
    [SerializeField] private PointDis touch;
    private bool isAlive;
    private void Start()
    {

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
        foreach (var component in controller)
        {
            component.enabled = active;
        }
    }
    private void Update()
    {
        if(touch.WasTouch == true)
        {
            StartBattle();
        }
        else if(touch.WasTouch == false || fireManHealth.isDead)
        {
            EndBattle();
        }
    }

}
