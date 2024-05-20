using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroShop : MonoBehaviour
{
    [SerializeField] private GameObject[] heroNumber;
    [SerializeField] private GameObject[] indexBar;
    [SerializeField] private GameObject[] noteIndex;
    [SerializeField] private GameObject[] indexHero;
    [SerializeField] private GameObject xButton;
    [SerializeField] private GameObject noteButton;
    [SerializeField] private GameObject buttonNext;
    [SerializeField] private GameObject buttonBack;
    [SerializeField] private int number;
    private void NumberIndex()
    {
        if (number >= 2 && number < 0)
        {
            return;
        }
        if (number > 0 && number < 3)
        {
            buttonBack.SetActive(true);
        }
        else
        {
            buttonBack.SetActive(false);
        }
        if (number >= 0 && number < 2)
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
        if (number < 2)
        {
            number++;
        }
        NumberIndex();
        for (int i = 0; i < heroNumber.Length; i++)
        {
            if (heroNumber[i] == heroNumber[number])
            {
                heroNumber[number].SetActive(true);
            }
            else
            {
                heroNumber[i].SetActive(false);
            }
        }
    }
    public void BackHero()
    {
        if (number > 0)
        {
            number--;
        }
        NumberIndex();
        for (int i = 0;i < heroNumber.Length;i++)
        {
            if (heroNumber[i] == heroNumber[number])
            {
                heroNumber[number].SetActive(true);
            }
            else
            {
                heroNumber[i].SetActive(false);
            }
        }
    }
    public void EnableNote()
    {
        for(int i = 0;i < indexBar.Length ; i++)
        {
            indexBar[i].SetActive(false);
            noteButton.SetActive(false);
            for(int j = 0; j < noteIndex.Length; j++)
            {
                noteIndex[j].SetActive(true);
                xButton.SetActive(true);
            }
        }
    }
    public void DissableNote()
    {
        for (int i = 0; i < noteIndex.Length; i++)
        {
            noteIndex[i].SetActive(false);
            xButton.SetActive(false);
            for (int j = 0; j < indexBar.Length; j++)
            {
                indexBar[j].SetActive(true);
                noteButton.SetActive(true);
            }
        }
    }
    public void BackMenu(string name)
    {
        SceneManager.LoadScene(name);
    }
    private void Update()
    {
        
    }

}
