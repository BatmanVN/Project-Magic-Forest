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
    public int bonusCount;
    public bool bonusEnabled;
    private void RandomBonus()
    {
        if (bonusPoint.isJumpBonus == true)
        {
            GameObject selectIndex = bonusIndex[bonusCount];
            selectIndex.SetActive(true);
            effect.SetActive(true);
            effectAnim.SetTrigger("isEffect");
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
