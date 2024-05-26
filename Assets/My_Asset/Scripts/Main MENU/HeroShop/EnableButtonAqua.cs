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
        if(buttonBuy.IsClick == true)
        {
            buy.SetActive(false);
            upgrade.SetActive(true);
        }
        else
        {
            buy.SetActive(true);
            upgrade.SetActive(false);
        }
    }
    private void GetIndex()
    {
        BuyAqua = PlayerPrefs.GetInt(keyName, BuyAqua);
    }
    private void Start()
    {
        GetIndex();
    }
    private void Update()
    {
        EnableButton();
    }
}
