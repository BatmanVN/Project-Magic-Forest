using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCoinADS : MonoBehaviour
{
    [SerializeField] private GameObject[] barNumber;
    public void ClickX(int number)
    {
        barNumber[number].SetActive(false);
    }
    private void Update()
    {
        
    }
}
