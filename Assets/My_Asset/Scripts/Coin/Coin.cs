using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject coinEnable;
    private void OnTriggerEnter2D(Collider2D coin)
    {
        if(coin.CompareTag("Player"))
        {
            coinEnable.SetActive(false);
        }
    }
}
