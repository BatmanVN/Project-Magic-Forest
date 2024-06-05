using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mana : MonoBehaviour
{
    [SerializeField] private string powerKey;
    [SerializeField] private Image powerBar;
    [SerializeField] private float mana;
    [SerializeField] private float maxMana;
    public float MaNa { get => mana; set => mana = value; }
    public float MaxMana { get => maxMana; set => maxMana = value; }
    public bool outMana => MaNa<=0;
    public string PowerKey { get => powerKey; set => powerKey = value; }
    [ContextMenu("GetPower")]
    private void Start()
    {
        GetPower();
    }
    private void GetPower()
    {
        MaxMana = PlayerPrefs.GetFloat(PowerKey,MaxMana);
        MaNa = MaxMana;
    }
    public void ConsumeMana(float useMana)
    {
        if(outMana)
        {
            return;
        }
        MaNa -= useMana;
        powerBar.fillAmount = MaNa / maxMana;
    }
    public void RestoreMaNa(float manaAmount)
    {
        if(MaNa >= MaxMana)
        {
            return;
        }
        MaNa += manaAmount;
        powerBar.fillAmount = MaNa / maxMana;
    }
}
