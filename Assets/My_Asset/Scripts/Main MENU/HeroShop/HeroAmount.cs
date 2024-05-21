using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HeroAmount : MonoBehaviour
{
    [SerializeField] private GameObject[] heroes;
    [SerializeField] private GameObject[] indexBar;
    [SerializeField] private int index;

    public int Index { get => index; set => index = value; }

    public void HeroIndexBar()
    {
        for (int i = 0; i < indexBar.Length; i++)
        {
            if (heroes[i] == heroes[index])
            {
                indexBar[Index].SetActive(true);
            }
            else
            {
                indexBar[i].SetActive(false);
            }
        }
    }
    private void Update()
    {
        
    }
}
