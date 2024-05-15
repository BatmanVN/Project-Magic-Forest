using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private List<MonoBehaviour> components;
    [SerializeField] private HealthCharacter healthComponent;
    //[SerializeField] private Player_attack attackComponent;
    //[SerializeField] private Player_beAttack beAttackComponent;
    //[SerializeField] private Player_jump jumpComponent;
    //[SerializeField] private Player_Move moveComponent;
    //[SerializeField] private Player_skillFire skillFireComponent;
    //[SerializeField] private Mana manaComponent;
    //[SerializeField] private Restoremana restoremanaComponent;
    private bool isPlaying = false;

    private void Start()
    {
        StartGame();
    }
    //private void Getcomponents()
    //{
    //    components.Add(healthComponent);
    //    components.Add(attackComponent);
    //    components.Add(beAttackComponent);
    //    components.Add(jumpComponent);
    //    components.Add(moveComponent);
    //    components.Add(skillFireComponent);
    //    components.Add(manaComponent);
    //    components.Add(restoremanaComponent);
    //}
    private void StartGame()
    {
        isPlaying = true;
        EnableComponents();
        Debug.Log("Start Game");
    }
    private void QuitGame()
    {
        isPlaying = false;
        DisableComponents();
        Debug.Log("END GAME");
    }
    private void EnableComponents()
    {
        SetactiveComponents(true);
    }
    private void DisableComponents()
    {
        SetactiveComponents(false);
    }
    private void SetactiveComponents(bool isActive)
    {
        foreach (var component in components)
        {
            component.enabled = isActive;
        }
    }
    private void Update()
    {
         if(!isPlaying)
        {
            return;
        }
         if(healthComponent.isDead)
        {
            QuitGame();
        }
    }
}
