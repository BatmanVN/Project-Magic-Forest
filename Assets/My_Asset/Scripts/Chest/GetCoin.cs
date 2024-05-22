using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoin : MonoBehaviour
{
    [SerializeField] private string coinName;
    [SerializeField] private int cointAmount;
    public int CointAmount { get => cointAmount; set => cointAmount = value; }

    [ContextMenu("Get")]
    private int Get()
    {
        CointAmount = PlayerPrefs.GetInt(coinName,CointAmount);
        return CointAmount;
    }
}
