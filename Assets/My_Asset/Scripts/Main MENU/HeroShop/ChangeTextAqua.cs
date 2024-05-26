using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextAqua : MonoBehaviour
{
    [SerializeField] private Buy_Aqua buy_Aqua;
    [SerializeField] private Text textBar;
    [SerializeField] private Text textCoin;
    
    private void ChangeText()
    {
        if(buy_Aqua.WasBuy == true)
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
