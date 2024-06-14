using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePoint : MonoBehaviour
{
    [SerializeField] private Health playerHealth;

    private void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.CompareTag("fakepoint"))
        {
            playerHealth.TakeDame(playerHealth.HealTH);
        }
    }
}
