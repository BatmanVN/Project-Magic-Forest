using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenDeath : MonoBehaviour
{
    private const string isDeathParaname = "isDie";
    [SerializeField] private Animator animator;
    [SerializeField] private HealthCharacter character;
    [SerializeField] private GameObject characterObj;
    [SerializeField] private float timeDelay;
    public bool isDie;
    private void Update()
    {
        WhenDie();
    }
    private void WhenDie()
    {
        if(character.isDead)
        {
            animator.SetTrigger(isDeathParaname);
            isDie = true;
        }
        if(isDie == true)
        {
            ObjectDisable();
        }
    }
    private void ObjectDisable()
    {
        InvokeRepeating(nameof(Disable), timeDelay, 0);
    }
    private void Disable()
    {
        if(isDie == true)
        {
            characterObj.SetActive(false);
        }
    }
}
