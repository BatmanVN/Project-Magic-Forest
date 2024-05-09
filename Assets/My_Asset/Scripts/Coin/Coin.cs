using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private CoinAmount amount;
    [SerializeField] private GameObject coinEnable;
    [SerializeField] private Animator coinAnim;
    [SerializeField] private float timeDelay;
    public bool isAnimator;
    private void OnTriggerEnter2D(Collider2D coin)
    {
        if(coin.CompareTag("Player"))
        {
            coinAnim.SetTrigger("isCollect");
            isAnimator = true;
            amount?.CountCoin();
        }
    }
    private void OnTriggerExit2D(Collider2D coin)
    {
        if (coin.CompareTag("Player"))
        {
            isAnimator = false;
        }
    }
    private void WhenCollect()
    {
            Destroy(coinEnable);
    }
    private IEnumerator Delay()
    {
        if (isAnimator == true)
        {
            yield return new WaitForSeconds(timeDelay);
            WhenCollect();
        }
    }
    private void Start()
    {
        amount = FindAnyObjectByType<CoinAmount>();
    }
    private void Update()
    {
        StartCoroutine(Delay());
    }
}
