using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoughtADS : MonoBehaviour
{
    [SerializeField] private GameObject boughtADS;
    [SerializeField] private GameObject removeADS;
    [SerializeField] private IAPRemoveADS iAP;

    private void Boughtads()
    {
        if(iAP.Bought == true)
        {
            boughtADS.SetActive(true);
            removeADS.SetActive(false);
        }
    }
    private void Update()
    {
        Boughtads();
    }
}
