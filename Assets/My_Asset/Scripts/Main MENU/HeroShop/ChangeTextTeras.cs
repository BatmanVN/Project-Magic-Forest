using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextTeras : MonoBehaviour
{
    [SerializeField] protected Buy_Teras buy_Teras;
    [SerializeField] private Text textBar;
    [SerializeField] private Text textCoin;

    private void ChangeText()
    {
        if (buy_Teras.WasBuy == true)
        {
            textBar.text = "Upgrade For";
            textCoin.text = "250";
        }
    }
    private void Update()
    {
        ChangeText();
    }
}
