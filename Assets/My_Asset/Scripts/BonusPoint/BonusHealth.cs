using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusHealth : MonoBehaviour
{
    [SerializeField] private GameObject healthObj;
    public bool eatHeart;
    private void OnTriggerEnter2D(Collider2D bonusSpeed)
    {
        if (bonusSpeed.CompareTag("Player"))
        {
            eatHeart = true;
            healthObj.SetActive(false);
        }
    }
}
