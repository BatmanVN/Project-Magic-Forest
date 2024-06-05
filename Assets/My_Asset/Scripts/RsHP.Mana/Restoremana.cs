using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restoremana : MonoBehaviour
{
    [SerializeField] private Mana mana;
    [SerializeField] private float delay;
    [SerializeField] private float manaAmount;

    private void Start()
    {
        DelayRestore();
    }
    private void DelayRestore()
    {
        InvokeRepeating(nameof(RestoreMana), delay,delay);
    }
    private void RestoreMana()
    {
        mana.RestoreMaNa(manaAmount);
    }
}
