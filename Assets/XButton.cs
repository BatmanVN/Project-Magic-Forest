using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButton : MonoBehaviour
{
    [SerializeField] private GameObject boughtADS;

    public void BoughtADS()
    {
        boughtADS.SetActive(false);
    }
}
