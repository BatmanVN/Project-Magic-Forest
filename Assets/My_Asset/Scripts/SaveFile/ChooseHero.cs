using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseHero : MonoBehaviour
{
    [SerializeField] private GameObject[] heroes;
    [SerializeField] private int indexHero;
    [SerializeField] private HeroManager manager;
    [SerializeField] private PlayerPrefsIntSaver intSaver;

    public int IndexHero { get => indexHero; set => indexHero = value; }

    public void SelectHero()
    {
        for (int i = 0; i < heroes.Length; i++)
        {
            if (heroes[i] == heroes[manager.Number])
            {
                IndexHero = manager.Number;
                intSaver.Value = IndexHero;
            }
        }
    }
    private void Update()
    {
        
    }
}
