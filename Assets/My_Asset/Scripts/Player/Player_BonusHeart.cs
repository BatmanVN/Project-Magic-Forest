using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusHeart : MonoBehaviour
{
    [SerializeField] Player_BonusHeart bonusHeart;
    [SerializeField] private Health character;
    [SerializeField] private float healAmount;
    public void BonusHeart()
    {
          character.Heal(healAmount);
          bonusHeart.enabled = false;
    }
    
    private void Update()
    {
        
    }
}
