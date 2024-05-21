using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsIntSaver : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private ChooseHero chooseHero;

    [ContextMenu("Save")]
    public void Save()
    {
        PlayerPrefs.SetInt(keyName, chooseHero.IndexHero);
    }
}
