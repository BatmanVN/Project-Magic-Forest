using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableButtonAqua : MonoBehaviour
{
    [SerializeField] private Buy_Aqua buttonBuy;
    [SerializeField] private GameObject buy;
    [SerializeField] private GameObject upgrade;
    [SerializeField] private string keyName;
    [SerializeField] private int buyAqua;

    public int BuyAqua { get => buyAqua; set => buyAqua = value; }

    [ContextMenu("GetIndex")]
    private void EnableButton()
    {
        GetIndex();
        if (BuyAqua == 1)
        {
            buy.SetActive(false);
            upgrade.SetActive(true);
        }
        else if (BuyAqua != 1)
        {
            buy.SetActive(true);
            upgrade.SetActive(false);
        }
    }
    private int GetIndex()
    {
        BuyAqua = PlayerPrefs.GetInt(keyName, buttonBuy.BuyAqua);
        return BuyAqua;
    }
    private void Start()
    {
    }
    private void Update()
    {
        EnableButton();
    }
}
