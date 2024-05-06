using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableCoinAmount : MonoBehaviour
{
    [SerializeField] private Text coinBar;
    [SerializeField] protected Text coinAmount;
    private void CoinBar()
    {
        coinBar.text = coinAmount.text;
    }
    private void Update()
    {
        CoinBar();
    }
}
