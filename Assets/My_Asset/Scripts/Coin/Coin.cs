using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
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
        if(isAnimator == true)
        {
            coinEnable.SetActive(false);
        }
    }
    private IEnumerator Delay()
    {
        if (isAnimator == true)
        {
            yield return new WaitForSeconds(timeDelay);
            WhenCollect();
        }
    }
    private void Update()
    {
        StartCoroutine(Delay());
    }
}
