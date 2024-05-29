using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableButtonTeras : MonoBehaviour
{
    [SerializeField] private Buy_Teras buttonBuy;
    [SerializeField] private GameObject buy;
    [SerializeField] private GameObject upgrade;
    [SerializeField] private string keyName;
    [SerializeField] private int buyTeras;

    public int BuyTeras { get => buyTeras; set => buyTeras = value; }

    [ContextMenu("GetIndex")]
    private void EnableButton()
    {
        if (buyTeras == 2)
        {
            buy.SetActive(false);
            upgrade.SetActive(true);
        }
        else if (buyTeras != 2)
        {
            buy.SetActive(true);
            upgrade.SetActive(false);
        }
    }
    private int GetIndex()
    {
        BuyTeras = PlayerPrefs.GetInt(keyName, buttonBuy.BuyTeras);
        return BuyTeras;
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
