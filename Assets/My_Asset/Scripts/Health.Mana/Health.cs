using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private string healthName;
    [SerializeField] private Image healthBar;
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;
    public float HealTH { get => health; private set => health = value; }
    public float MaxHealth { get => maxHealth; private set => maxHealth = value; }
    public bool isAlive => health > 0;
    public bool isDead => health <= 0;

    public string HealthName { get => healthName; set => healthName = value; }
    [ContextMenu("GetHealthKey")]

    private void Start()
    {
        GetHealthKey();
    }
    private void GetHealthKey()
    {
        MaxHealth = PlayerPrefs.GetFloat(HealthName, MaxHealth);
        HealTH = MaxHealth;
    }
    public void TakeDame(float dame)
    {
        if (isDead)
        {
            return;
        }
        HealTH -= dame;
        healthBar.fillAmount = HealTH / MaxHealth;
    }
    public void Heal(float healAmount)
    {
        if (isDead)
        {
            return;
        }
        if (HealTH >= MaxHealth)
        {
            return;
        }
        HealTH += healAmount;
        healthBar.fillAmount = HealTH / MaxHealth;
    }
}
