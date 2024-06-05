using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextHero : MonoBehaviour
{
    [SerializeField] private Ignius_Indexs level;
    [SerializeField] private Text textBar;
    [SerializeField] private Text textCoin;
    
    private void ChangeText()
    {
        if(level.Level == 1)
        {
            textBar.text = "Upgrade For";
            textCoin.text = "250";
        }
        if (level.Level == 2)
        {
            textBar.text = "Upgrade For";
            textCoin.text = "500";
        }
        if (level.Level == 3)
        {
            textBar.text = "Upgrade For";
            textCoin.text = "750";
        }
    }
    private void Update()
    {
        ChangeText();
    }
}
