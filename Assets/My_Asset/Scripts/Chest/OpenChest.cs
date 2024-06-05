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
    [SerializeField] private EnableChestOnHead enableChestOn;
    private bool hasRewardChest;

    public bool HasRewardChest { get => hasRewardChest; set => hasRewardChest = value; }

    private void OnTriggerEnter2D(Collider2D Chest)
    {
        if (Chest.CompareTag("Player"))
        {
            HasRewardChest = true;
            chestAnim.SetTrigger(isOpenParaname);
            enableChestOn?.EnableChest();
        }
    }
    private void Update()
    {
        
    }
}
