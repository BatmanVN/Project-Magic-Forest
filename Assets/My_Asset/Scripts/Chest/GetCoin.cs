using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCoin : MonoBehaviour
{
    [SerializeField] private string coinName;
    [SerializeField] private int getCoin;
    public int CointAmount { get => getCoin; set => getCoin = value; }

    [ContextMenu("Get")]
    private int Get()
    {
        getCoin = PlayerPrefs.GetInt(coinName, getCoin);
        return getCoin;
    }
    private void Start()
    {
        Get();
    }
}
