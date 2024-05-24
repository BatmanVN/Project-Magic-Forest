using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_attack : MonoBehaviour
{
    [SerializeField] private GameObject[] ballAttack;
    [SerializeField] private ChangeSprite indexSprites;
    [SerializeField] private Transform ballAttackRight;
    [SerializeField] private Player_Move move;
    [SerializeField] private SpriteRenderer[] fireRender;
    [SerializeField] private Mana useMana;
    [SerializeField] private float Dame;
    [SerializeField] private float dameSke;
    [SerializeField] private float mana;
    public float dame { get => Dame; private set => Dame = value; }
    public float DameSke { get => dameSke; private set => dameSke = value; }
    public void Attack()
    {

        for(int i = 0; i < ballAttack.Length; i++)
        {
            if(indexSprites.Index == 0)
            {
                if (move.IsFlip == true)
                {
                    fireRender[indexSprites.Index].flipX = true;
                }
                if (move.IsFlip == false)
                {
                    fireRender[indexSprites.Index].flipX = false;
                }
                if (useMana.MaNa <= 0)
                {
                    return;
                }
                Instantiate(ballAttack[indexSprites.Index], ballAttackRight.position, Quaternion.identity);
                useMana.ConsumeMana(mana);
            }
            if(indexSprites.Index == 1)
            {
                if (move.IsFlip == true)
                {
                    fireRender[indexSprites.Index].flipX = true;
                }
                if (move.IsFlip == false)
                {
                    fireRender[indexSprites.Index].flipX = false;
                }
                if (useMana.MaNa <= 0)
                {
                    return;
                }
                Instantiate(ballAttack[1], ballAttackRight.position, Quaternion.identity);
                useMana.ConsumeMana(mana);
            }
        }
    }
    private void Start()
    {
        
    }
}
