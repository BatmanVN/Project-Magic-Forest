using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePoint : MonoBehaviour
{
    [SerializeField] private ChangeSprite_fireman status1;
    [SerializeField] private GameObject healthBar;
    [SerializeField] private BoxCollider2D pointA;
    [SerializeField] private BoxCollider2D pointB;
    [SerializeField] private Health firemanHP;
    [SerializeField] private float delayTime;
    private void OnTriggerEnter2D(Collider2D pointa)
    {
        if(pointa.CompareTag("Player"))
        {
            StartCoroutine(Delay());
            healthBar.SetActive(true);
        }
    }
    private void BossDie()
    {
        if(firemanHP.isDead)
        {
            pointB.isTrigger = true;
            healthBar.SetActive(false);
        }
    }
    private void ChangeTrigger()
    {
        pointA.isTrigger = false;
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayTime);
        ChangeTrigger();
    }
    private void Update()
    {
        BossDie();
    }
}
