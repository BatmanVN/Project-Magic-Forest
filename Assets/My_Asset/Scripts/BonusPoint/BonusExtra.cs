using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusExtra : MonoBehaviour
{
    [SerializeField] private Player_Move move;
    [SerializeField] private HealthCharacter character;
    [SerializeField] private GameObject[] index;
    [SerializeField] private float Defdame;
    [SerializeField] private float health;
    [SerializeField] private float speed;
    public bool defIndex;
    public bool healIndex;
    public bool speedIndex;
    private void OnTriggerEnter2D(Collider2D Player)
    {
        if(Player.CompareTag("DefIndex"))
        {
            defIndex = true;
            index[0].SetActive(false);
        }
        if (Player.CompareTag("HealIndex"))
        {
            healIndex = true;
            index[1].SetActive(false);
        }
        if (Player.CompareTag("SpeedIndex"))
        {
            speedIndex = true;
            index[2].SetActive(false);
        }
    }
    private void DefDame()
    {
        if (defIndex)
        {
            character.TakeDame(Defdame);
        }
    }
}
