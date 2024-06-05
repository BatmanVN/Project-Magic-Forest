using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCoinSound : MonoBehaviour
{
    [SerializeField] private AudioSource coinSound;

    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.CompareTag("Coin"))
        {
            coinSound.Play();
        }
    }
}
