using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseLightSkill : MonoBehaviour
{
    [SerializeField] private GameObject blackGround;
    [SerializeField] private Health fireManHealth;
    [SerializeField] private Fireman_Attack normalAttack;
    [SerializeField] private GameObject skillPoint;
    [SerializeField] private GameObject lightSkill;
    [SerializeField] private Transform lightPostion;
    [SerializeField] private int count;
    [SerializeField] private float dameSkill;
    public float DameSkill { get => dameSkill; set => dameSkill = value; }

    private void UseSkill()
    {
        if(fireManHealth.HealTH <= 25)
        {
            if(count < 3)
            {
                Instantiate(lightSkill, lightPostion.position, Quaternion.identity);
                count += 1;
            }
            normalAttack.enabled = false;
            Disable();
        }
    }
    private void Disable()
    {
        if(count >= 3)
        {
            skillPoint.SetActive(false);
            Destroy(blackGround);
            normalAttack.enabled = true;
        }
    }
    private void Start()
    {
        InvokeRepeating(nameof(UseSkill), 1, 2);
    }
}
