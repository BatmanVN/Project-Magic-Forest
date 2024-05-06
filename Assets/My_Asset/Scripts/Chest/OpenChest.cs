using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;

public class OpenChest : MonoBehaviour
{
    private const string isOpenParaname = "isOpen";
    [SerializeField] private GameObject chest;
    [SerializeField] private Collider2D chestCollider;
    [SerializeField] private Animator chestAnim;
    public bool hasRewardChest;
    private void OnTriggerEnter2D(Collider2D Chest)
    {
        if (Chest.CompareTag("Player"))
        {
            hasRewardChest = true;
            chestAnim.SetTrigger(isOpenParaname);
        }
    }
    private void Update()
    {
        
    }
}
