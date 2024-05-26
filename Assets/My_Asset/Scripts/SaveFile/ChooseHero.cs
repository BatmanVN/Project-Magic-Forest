using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseHero : MonoBehaviour
{
    [SerializeField] private GameObject[] heroes;
    [SerializeField] private EnableButtonAqua aquana;
    [SerializeField] private EnableButtonTeras teras;
    [SerializeField] private int indexHero;
    [SerializeField] private HeroManager manager;
    [SerializeField] private string keyName;
    public int IndexHero { get => indexHero; set => indexHero = value; }

    [ContextMenu("SelectHero")]
    public void SelectHero()
    {
        for (int i = 0; i < heroes.Length; i++)
        {
                if (aquana.BuyAqua == 1)
                {
                    manager.Number = 1;
                }

                if (teras.BuyTeras == 2)
                {
                    manager.Number = 2;
                }
                if (i == 0)
                {
                    manager.Number = 0;
                }
                IndexHero = manager.Number;
                PlayerPrefs.SetInt(keyName, IndexHero);
        }
    }
    private void Update()
    {

    }
}
