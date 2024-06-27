using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePoint : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Player_beAttack die;

    private void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.CompareTag("fakepoint"))
        {
            playerHealth.TakeDame(playerHealth.MaxHealth);
            die.TakeDameFakePoint();
        }
    }
}
