using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackBackGround : MonoBehaviour
{
    [SerializeField] private Image blackGround;
    [SerializeField] private Health firemanHealth;
    [SerializeField] private float timeDelay;
    private bool wasChange;
    private void ChangeBlackGround()
    {
        Color colorA = blackGround.color;
        if(firemanHealth.HealTH <= 25)
        {
            if (wasChange == false)
            {
                colorA.a += 1f;
                blackGround.color = colorA;
                wasChange = true;
            }
            StartCoroutine(Delay());
        }
        Debug.Log(colorA.a);
    }
    private void DownBlack()
    {
        Color colorA = blackGround.color;
        if (wasChange == true)
        {
            colorA.a -= 1f;
            blackGround.color = colorA;
            wasChange = false;
        }
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(timeDelay);
        DownBlack();
    }
    private void Update()
    {
        ChangeBlackGround();
    }
}
