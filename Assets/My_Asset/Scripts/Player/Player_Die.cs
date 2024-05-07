using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Die : MonoBehaviour
{
    private const string isDieParaname = "isDie";
    [SerializeField] private HealthCharacter character;
    [SerializeField] private Animator animator;
    public bool isDieAnim;
    private void Death()
    {
        if(character.isDead)
        {
            animator.SetTrigger(isDieParaname);
            isDieAnim = true;
        }
    }
    private void Update()
    {
        Death();
    }
}
