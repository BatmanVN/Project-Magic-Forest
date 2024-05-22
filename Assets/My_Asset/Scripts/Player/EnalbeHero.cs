using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnalbeHero : MonoBehaviour
{
    [SerializeField] private GameObject[] objHero;
    [SerializeField] private string keyName;
    [SerializeField] private int index;

    public int Index { get => index; set => index = value; }

    [ContextMenu("IndexEnable")]

    private void Awake()
    {
        IndexEnable();
    }
    private int IndexEnable()
    {
        Index = PlayerPrefs.GetInt(keyName,Index);
        return Index;
    }
    private void HeroEnable()
    {
        for (int i = 0; i <= objHero.Length; i++)
        {
            if (objHero[i] == objHero[Index])
            {
                objHero[Index].SetActive(true);
                break;
            }
            else
            {
                objHero[i].SetActive(false);
            }
        }
    }
    private void Start()
    {
        HeroEnable();
    }
}
