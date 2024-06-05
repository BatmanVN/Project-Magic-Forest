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
    private bool isAnimator;

    public bool IsAnimator { get => isAnimator; set => isAnimator = value; }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if(coin.CompareTag("Player"))
        {
            coinAnim.SetTrigger("isCollect");
            amount?.CountCoinAmount();
            StartCoroutine(Delay());
        }
    }
    private void OnTriggerExit2D(Collider2D coin)
    {
        if (coin.CompareTag("Player"))
        {
            IsAnimator = false;
        }
    }
    private void WhenCollect()
    {
            Destroy(coinEnable);
    }
    private IEnumerator Delay()
    {
            yield return new WaitForSeconds(timeDelay);
            WhenCollect();
    }
    private void Start()
    {
        amount = FindAnyObjectByType<CoinAmount>();
    }
    private void Update()
    {
        
    }
}
