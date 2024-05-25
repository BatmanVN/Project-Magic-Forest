using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseHero : MonoBehaviour
{
    [SerializeField] private GameObject[] heroes;
    [SerializeField] private Buy_Hero[] buyHero;
    [SerializeField] private int indexHero;
    [SerializeField] private HeroManager manager;
    [SerializeField] private string keyName;
    public int IndexHero { get => indexHero; set => indexHero = value; }

    [ContextMenu("SelectHero")]
    public void SelectHero()
    {
        for (int i = 0; i < heroes.Length; i++)
        {
            if (heroes[i] == heroes[manager.Number])
            {
                if (buyHero[0].WasBuy == false)
                {
                    return;
                }
                if (buyHero[1].WasBuy == false)
                {
                    return;
                }
                IndexHero = manager.Number;
                PlayerPrefs.SetInt(keyName, IndexHero);
            }
        }
    }
    private void Update()
    {

    }
}
