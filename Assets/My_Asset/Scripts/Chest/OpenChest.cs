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
    [SerializeField] private float numberChest;
    [SerializeField] private float checkChest;
    public bool hasRewardChest;
    public bool isRewardChest;
    private void OnTriggerEnter2D(Collider2D Chest)
    {
        if (Chest.CompareTag("Player"))
        {
            isRewardChest = true;
            chestAnim.SetTrigger(isOpenParaname);
        }
    }
    private void OnTriggerExit2D(Collider2D Chest)
    {
        if (Chest.CompareTag("Player"))
        {
            isRewardChest = false;
        }
    }
    private void CheckChest()
    {
        if (isRewardChest == true)
        {
            for (numberChest = 0; numberChest <= 3; numberChest++)
            {
                if (numberChest == checkChest)
                {
                    chestCollider.enabled = false;
                    break;
                }
                if (numberChest >= 3)
                {
                    return;
                }
            }
        }
        if(isRewardChest == false)
        {
            return;
        }
    }
    private void Update()
    {
        CheckChest();
    }
}
