using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGateBar : MonoBehaviour
{
    [SerializeField] private OpenChest[] hasChest;
    [SerializeField] private GameObject[] Chest;
    //[SerializeField] private GameObject goldChest1;
    //[SerializeField] private GameObject goldChest2;
    

    public void RewardChest()
    {
        for (int i = 0; i < hasChest.Length; i++)
        {
            if (hasChest[i].hasRewardChest)
            {
                Chest[i].SetActive(true);
            }
        }
    }
}
