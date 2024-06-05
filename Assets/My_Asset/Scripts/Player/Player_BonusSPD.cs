using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusSPD : MonoBehaviour
{
    [SerializeField] private Player_BonusSPD disable;
    [SerializeField] private Player_Move moveSpeed;
    [SerializeField] private Animator speedAnim;
    [SerializeField] private GameObject speedObj;
    [SerializeField] private float timeBonus;
    [SerializeField] private float speedBonus;

    public void EnableEffect()
    {
            moveSpeed.EnableSpeedUP(speedBonus);
            speedObj.SetActive(true);
            speedAnim.SetTrigger("speedEffect");
            StartCoroutine(BonusTime());
    }
    private void Desttroybonus()
    {
        speedObj.SetActive(false);
        moveSpeed.EnableSpeedUP(-speedBonus);
        Destroy(disable);
    }
    private IEnumerator BonusTime()
    {
        yield return new WaitForSeconds(timeBonus);
        Desttroybonus();
    }
    private void Update()
    {
        
    }
}
