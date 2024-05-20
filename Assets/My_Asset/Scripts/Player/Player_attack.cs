using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour
{
    [SerializeField] private GameObject fireBall;
    [SerializeField] private Transform fireBallRight;
    [SerializeField] private Player_Move move;
    [SerializeField] private SpriteRenderer fireRender;
    [SerializeField] private Mana useMana;
    [SerializeField] private float Dame;
    [SerializeField] private float dameSke;
    [SerializeField] private float mana;
    public float dame { get => Dame; private set => Dame = value; }
    public float DameSke { get => dameSke; private set => dameSke = value; }
    public void Attack()
    {
        if (move.IsFlip == true)
        {
            fireRender.flipX = true;
        }
        if (move.IsFlip == false)
        {
            fireRender.flipX = false;
        }
        if(useMana.MaNa <= 0)
        {
            return;
        }
        Instantiate(fireBall, fireBallRight.position, Quaternion.identity);
        useMana.ConsumeMana(mana);
    }
    private void Update()
    {
        
    }
}
