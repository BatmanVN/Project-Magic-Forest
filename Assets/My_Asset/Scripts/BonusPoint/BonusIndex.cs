using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BonusIndex : MonoBehaviour
{
    [SerializeField] private Jump_BonusPoint bonusPoint;
    [SerializeField] private GameObject[] bonusIndex;
    public int bonusCount;
    public bool bonusEnabled;
    private void RandomBonus()
    {
        if (bonusPoint.isJumpBonus == true)
        {
            GameObject selectIndex = bonusIndex[bonusCount];
            selectIndex.SetActive(true);
            bonusPoint.isJumpBonus = false;
        }
    }
    private void Update()
    {
        RandomBonus();
    }
    private void Start()
    {
        bonusCount = Random.Range(0, bonusIndex.Length);
    }
}
