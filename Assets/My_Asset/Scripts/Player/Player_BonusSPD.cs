using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusSPD : MonoBehaviour
{
    [SerializeField] private Player_BonusSPD disable;
    [SerializeField] private BonusSpeed bonusSpeed;
    [SerializeField] private float timeBonus;
    [SerializeField] private float speedBonus;
    public float SpeedBonus { get => speedBonus; private set => speedBonus = value; }
    private void Desttroybonus()
    {
        bonusSpeed.speedUp = false;
        Destroy(disable);
    }
    IEnumerator BonusTime()
    {
        yield return new WaitForSeconds(timeBonus);
        Desttroybonus();
    }
    private void Update()
    {
        if(bonusSpeed.speedUp == true)
        {
            StartCoroutine(BonusTime());
        } 
    }
}
