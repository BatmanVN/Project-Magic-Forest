using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCoinADS : MonoBehaviour
{
    [SerializeField] private GameObject adsBar;
    public void ClickX()
    {
        adsBar.SetActive(false);
    }
}
