using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnableChestOnHead : MonoBehaviour
{
    [SerializeField] private OpenChest[] hasChest;
    [SerializeField] private Image[] enableImage;

    public void EnableChest()
    {
        for(int i = 0; i < hasChest.Length; i++)
        {
            if (hasChest[i].hasRewardChest)
            {
                Color color = enableImage[i].color;
                color.a = 250;
                enableImage[i].color = color;
            }
        }
    }
}
