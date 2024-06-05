using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusHealth : MonoBehaviour
{
    [SerializeField] private GameObject healthObj;
    [SerializeField] private GameObject effect;
    [SerializeField] private Player_BonusHeart bonusHeart;

    //public bool eatHeart;
    private void OnTriggerEnter2D(Collider2D bonusSpeed)
    {
        if (bonusSpeed.CompareTag("Player"))
        {
            bonusHeart?.BonusHeart();
            healthObj.SetActive(false);
            effect.SetActive(false);
        }
    }
}
