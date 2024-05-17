using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Menu : MonoBehaviour
{
    [SerializeField] private GameObject adsBar;

    public void EnableAdsBar()
    {
        adsBar.SetActive(true);
    }
}
