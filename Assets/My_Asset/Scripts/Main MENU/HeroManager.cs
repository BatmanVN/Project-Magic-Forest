using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HeroManager : MonoBehaviour
{
    [SerializeField] private GameObject[] heroNumber;
    [SerializeField] private GameObject[] heroText;
    [SerializeField] private GameObject[] heroTextBuy;
    [SerializeField] private Buy_Hero[] buyHero;
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
            if (buyHero[0].WasBuy == false)
            {

            }
            if (heroNumber[i] == heroNumber[Number])
            {
                    heroNumber[Number].SetActive(true);
                    heroText[Number].SetActive(true);
                    heroAmount.Index = Number;
            }
            else
            {
                heroNumber[i].SetActive(false);
                heroText[i].SetActive(false);
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
                    heroText[Number].SetActive(true);
                    heroAmount.Index = Number;
            }
            else
            {
                heroNumber[i].SetActive(false);
                heroText[i].SetActive(false);
            }
        }
        heroAmount?.HeroIndexBar();
    }
    private void Update()
    {
        
    }
}
