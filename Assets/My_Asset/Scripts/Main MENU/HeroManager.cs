using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HeroManager : MonoBehaviour
{
    [SerializeField] private GameObject[] heroNumber;
    [SerializeField] private HeroAmount heroAmount;
    [SerializeField] private GameObject buttonNext;
    [SerializeField] private GameObject buttonBack;
    [SerializeField] private int number;

    public int Number { get => number; set => number = value; }

    private void NumberIndex()
    {
        if (Number >= 2 && Number < 0)
        {
            return;
        }
        if (Number > 0 && Number < 3)
        {
            buttonBack.SetActive(true);
        }
        else
        {
            buttonBack.SetActive(false);
        }
        if (Number >= 0 && Number < 2)
        {
            buttonNext.SetActive(true);
        }
        else
        {
            buttonNext.SetActive(false);
        }
    }
    public void NextHero()
    {
        if (Number < 2)
        {
            Number++;
        }
        NumberIndex();
        for (int i = 0; i < heroNumber.Length; i++)
        {
            if (heroNumber[i] == heroNumber[Number])
            {
                heroNumber[Number].SetActive(true);
                heroAmount.Index = Number;
            }
            else
            {
                heroNumber[i].SetActive(false);
            }
        }
        heroAmount?.HeroIndexBar();
    }
    public void BackHero()
    {
        if (Number > 0)
        {
            Number--;
        }
        NumberIndex();
        for (int i = 0; i < heroNumber.Length; i++)
        {
            if (heroNumber[i] == heroNumber[Number])
            {
                heroNumber[Number].SetActive(true);
                heroAmount.Index = Number;
            }
            else
            {
                heroNumber[i].SetActive(false);
            }
        }
        heroAmount?.HeroIndexBar();
    }
    private void Update()
    {
        
    }
}
