using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnalbeHero : MonoBehaviour
{
    [SerializeField] private GameObject[] objHero;
    [SerializeField] private string keyName;
    [SerializeField] private int index;

    [ContextMenu("IndexEnable")]

    private int IndexEnable()
    {
        index = PlayerPrefs.GetInt(keyName,index);
        return index;
    }
    private void HeroEnable()
    {
        for (int i = 0; i <= objHero.Length; i++)
        {
            if (objHero[i] == objHero[index])
            {
                objHero[index].SetActive(true);
                break;
            }
            else
            {
                objHero[i].SetActive(false);
            }
        }
    }
    private void Update()
    {
        HeroEnable();
    }
    private void Start()
    {
        IndexEnable();
    }
}
