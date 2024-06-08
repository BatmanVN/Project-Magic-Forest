using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAPRemoveADS : MonoBehaviour
{
    private bool bought;

    public bool Bought { get => bought; set => bought = value; }

    public void OnPurchaseComplete(Product product)
    {
        bought = true;
    }
}
