using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusExtra : MonoBehaviour
{
    [SerializeField] private MonoBehaviour bonusComponent;
    [SerializeField] private HealthCharacter character;
    [SerializeField] private GameObject[] index;
    [SerializeField] private float Defdame;
    [SerializeField] private float healAmount;
    [SerializeField] private float speedBonus;
    [SerializeField] private float timeBonus;
    public float Speed { get => speedBonus; private set => speedBonus = value; }
    public bool defIndex;
    public bool healIndex;
    public bool speedIndex;
    private void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.CompareTag("DefIndex"))
        {
            defIndex = true;
            index[0].SetActive(false);
        }
        if(Player.CompareTag("HealIndex"))
        {
            healIndex = true;
            index[1].SetActive(false);
        }
        if(Player.CompareTag("SpeedIndex"))
        {
            speedIndex = true;
            index[2].SetActive(false);
        }
    }
    private void BonusIndex()
    {
        if (defIndex == true)
        {
            character.TakeDame(Defdame);
        }
        if(healIndex == true)
        {
            character.Heal(healAmount);
        }
        if(speedIndex == true)
        {
            Speed = speedBonus;
        }
        if(defIndex == false || healIndex == false || speedIndex == false)
        {
            return;
        }
    }
    private IEnumerator bonusTime()
    {
        if (defIndex == true)
        {
            yield return new WaitForSeconds(timeBonus);
            defIndex = false;
        }
        if(healIndex == true)
        {
            yield return new WaitForSeconds(timeBonus);
            healIndex = false;
        }
        if (speedIndex == true)
        {
            yield return new WaitForSeconds(timeBonus);
            speedIndex = false;
        }    
    }
    private void Update()
    {
        BonusIndex();
        bonusTime();
    }
}
