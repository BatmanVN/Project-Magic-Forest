using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Menu : MonoBehaviour
{
    [SerializeField] private GameObject[] adsBar;
    
    public void EnableAdsBar(int number)
    {
        for (int i = 0; i < adsBar.Length; i++)
        {
            if (adsBar[i] == adsBar[number])
            {
                adsBar[number].SetActive(true);
            }
            else
            {
                adsBar[i].SetActive(false);
            }
        }
    }
}
