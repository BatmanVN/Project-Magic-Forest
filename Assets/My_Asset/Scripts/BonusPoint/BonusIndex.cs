using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BonusIndex : MonoBehaviour
{
    [SerializeField] private BonusPoint bonusPoint;
    [SerializeField] private GameObject[] bonusIndex;
    public int bonusCount;
    public bool bonusDisAble;
    private void RandomBonus()
    {
        if (bonusPoint.jumpEnabled == true)
        {
            bonusCount = Random.Range(0, bonusIndex.Length);
            GameObject selectIndex = bonusIndex[bonusCount];
            selectIndex.SetActive(true);
        }
    }
    private void Update()
    {
         RandomBonus();
    }
}
