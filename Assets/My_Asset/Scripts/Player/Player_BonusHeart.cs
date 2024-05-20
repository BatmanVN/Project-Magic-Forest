using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusHeart : MonoBehaviour
{
    [SerializeField] Player_BonusHeart bonusHeart;
    [SerializeField] private BonusHealth bonusHealth;
    [SerializeField] private HealthCharacter character;
    [SerializeField] private float healAmount;
    [SerializeField] private Bool_Class eatHeart;
    private void BonusHeart()
    {
        if(eatHeart.boolRef == true)
        {
            character.Heal(healAmount);
            eatHeart.boolRef = false;
            if(eatHeart.boolRef == false)
            {
                DestroyBonus();
            }
        }
    }
    private void DestroyBonus()
    {
        if (eatHeart.boolRef == false)
        {
            Destroy(bonusHeart);
        }
    }
    private void Update()
    {
        BonusHeart();
    }
}
