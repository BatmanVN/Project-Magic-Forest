using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireman_controller : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> controller;
    [SerializeField] private Health fireManHealth;
    [SerializeField] private PointDis touch;
    private void Start()
    {

    }
    private void StartBattle()
    {
        EnableComponents();
    }
    private void EndBattle()
    {
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
    private void StartGame()
    {
            StartBattle();
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        StartGame();
    }
    private void Update()
    {
        if(touch.WasTouch == true)
        {
            StartCoroutine(Delay());
        }
        else if(touch.WasTouch == false || fireManHealth.isDead)
        {
            EndBattle();
        }
    }

}
