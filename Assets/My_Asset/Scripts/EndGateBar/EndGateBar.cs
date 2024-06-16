using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGateBar : MonoBehaviour
{
    [SerializeField] private OpenChest[] hasChest;
    [SerializeField] private GameObject[] Chest;
    [SerializeField] private string chest1;
    [SerializeField] private string chest2;
    [SerializeField] private string chest3;
    [SerializeField] private int chestOpen1;
    [SerializeField] private int chestOpen2;
    [SerializeField] private int chestOpen3;
    [ContextMenu("SaveChest")] 

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

    private void CheckChestGot()
    {
        if(hasChest[0].HasRewardChest == true)
        {
            chestOpen1 = 1;
        }
        if (hasChest[1].HasRewardChest == true)
        {
            chestOpen2 = 2;
        }
        if (hasChest[2].HasRewardChest == true) 
        {
            chestOpen3 =3;
        }
        PlayerPrefs.SetInt(chest1, chestOpen1);
        PlayerPrefs.SetInt(chest2, chestOpen2);
        PlayerPrefs.SetInt(chest3, chestOpen3);
    }
    private void Update()
    {
        CheckChestGot();
    }
}
