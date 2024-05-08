using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusSPD : MonoBehaviour
{
    [SerializeField] private Player_BonusSPD disable;
    [SerializeField] private Rigidbody2D bonusSpeed2D;
    [SerializeField] private Vector2 moveSpeedUp;
    [SerializeField] private float speed;
    public void SpeedUP()
    {
        var powerSpeed = moveSpeedUp;
        powerSpeed *= speed;
        bonusSpeed2D.velocity = powerSpeed;
    }
    private void Desttroybonus()
    {
        disable.enabled = false;
    }
    IEnumerator BonusTime()
    {
        yield return new WaitForSeconds(3);
        Desttroybonus();
    }
    private void Update()
    {
        BonusTime();
    }
}
