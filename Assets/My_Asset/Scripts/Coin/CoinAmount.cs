using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{
    [SerializeField] private Text coinText;
    [SerializeField] private Text coinTextBar;
    [SerializeField] private int countCoin;
    [SerializeField] private float delay;
    public bool getCoin;
    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Coin"))
        {
            getCoin = true;
        }
    }
    private void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Coin"))
        {
            getCoin = false;
        }
    }
    private void CoinCount()
    {
        if (getCoin == true)
        {
            countCoin += 1;
        }
        coinText.text = countCoin.ToString();
    }
    private void Start()
    {
            InvokeRepeating(nameof(CoinCount), delay, delay);
    }
}
