using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusSPD : MonoBehaviour
{
    [SerializeField] private Player_BonusSPD disable;
    [SerializeField] private BonusSpeed bonusSpeed;
    [SerializeField] private Animator speedAnim;
    [SerializeField] private GameObject speedObj;
    [SerializeField] private float timeBonus;
    [SerializeField] private float speedBonus;
    public float SpeedBonus { get => speedBonus; private set => speedBonus = value; }

    private void SpeedEffect()
    {
        if(bonusSpeed.speedUp == true)
        {
            speedObj.SetActive(true);
            speedAnim.SetTrigger("speedEffect");
            StartCoroutine(BonusTime());
        }
    }
    private void Desttroybonus()
    {
        speedObj.SetActive(false);
        bonusSpeed.speedUp = false;
        Destroy(disable);
    }
    private IEnumerator BonusTime()
    {
        yield return new WaitForSeconds(timeBonus);
        Desttroybonus();
    }
    private void Update()
    {
        SpeedEffect();
    }
}
