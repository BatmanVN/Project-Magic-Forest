using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGateBar : MonoBehaviour
{
    [SerializeField] private OpenChest[] hasChest;
    [SerializeField] private GameObject[] Chest;

    

    public void RewardChest()
    {
        for (int i = 0; i < hasChest.Length; i++)
        {
            if (hasChest[i].HasRewardChest)
            {
                Chest[i].SetActive(true);
            }
        }
    }
}
