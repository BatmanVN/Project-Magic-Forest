using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Menu : MonoBehaviour
{
    [SerializeField] private GameObject[] adsBar;
    [SerializeField] private string sceneName;
    public void EnableAdsBar(int number)
    {
        for (int i = 0; i < adsBar.Length; i++)
        {
            if (adsBar[i] == adsBar[number])
            {
                adsBar[number].SetActive(true);
                if (adsBar[i] == adsBar[4])
                {
                    SceneManager.LoadScene(sceneName);
                }
            }
            else
            {
                adsBar[i].SetActive(false);
            }
        }
    }
}
