using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BonusIndex : MonoBehaviour
{
    [SerializeField] private Animator effectAnim;
    [SerializeField] private Jump_BonusPoint bonusPoint;
    [SerializeField] private GameObject[] bonusIndex;
    [SerializeField] private GameObject effect;
    [SerializeField] private int bonusCount;

    private void RandomBonus()
    {
        if (bonusPoint.IsJumpBonus == true)
        {
            GameObject selectIndex = bonusIndex[bonusCount];
            selectIndex.SetActive(true);
            effect.SetActive(true);
            effectAnim.SetTrigger("isEffect");
            bonusPoint.IsJumpBonus = false;
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
