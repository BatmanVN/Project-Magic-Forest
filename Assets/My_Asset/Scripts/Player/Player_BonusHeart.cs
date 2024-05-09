using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusHeart : MonoBehaviour
{
    [SerializeField] Player_BonusHeart bonusHeart;
    [SerializeField] private BonusHealth bonusHealth;
    [SerializeField] private HealthCharacter character;
    [SerializeField] private float healAmount;
    private void BonusHeart()
    {
        if(bonusHealth.eatHeart == true)
        {
            character.Heal(healAmount);
            bonusHealth.eatHeart = false;
            if(bonusHealth.eatHeart == false)
            {
                DestroyBonus();
            }
        }
    }
    private void DestroyBonus()
    {
        if (bonusHealth.eatHeart == false)
        {
            Destroy(bonusHeart);
        }
    }
    private void Update()
    {
        BonusHeart();
    }
}
