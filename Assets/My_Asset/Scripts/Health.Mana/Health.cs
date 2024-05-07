using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCharacter : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;
    public float Health { get => health ; private set => health = value; }
    public float MaxHealth { get => maxHealth ; private set => maxHealth = value; }
    public bool isAlive => health > 0;
    public bool isDead => health <= 0;

    private void Awake()
    {
        Health = MaxHealth;
    }
    private void Update()
    {
        
    }
    public void TakeDame(float dame)
    {
        if (isDead)
        {
            return;
        }
        Health -= dame;
        healthBar.fillAmount = Health / MaxHealth;
    }
    public void Heal(float healAmount)
    {
        if(isDead)
        {
            return;
        }
        if(Health >= MaxHealth)
        {
            return;
        }
        Health += healAmount;
        healthBar.fillAmount = Health / MaxHealth;
    }
}
