using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckChest : MonoBehaviour
{
    [SerializeField] private string chest1;
    [SerializeField] private string chest2;
    [SerializeField] private string chest3;
    [SerializeField] private int chestOpen1;
    [SerializeField] private int chestOpen2;
    [SerializeField] private int chestOpen3;
    [SerializeField] private GameObject[] chestGot;

    [ContextMenu("GetChestGot")]

    private void WhenGotChest()
    {
        if(chestOpen1 == 1)
        {
            chestGot[0].SetActive(true);
        }
        else
        {
            chestGot[0].SetActive(false);
        }
        if(chestOpen2 == 2)
        {
            chestGot[1].SetActive(true);
        }
        else
        {
            chestGot[1].SetActive(false);
        }
        if (chestOpen3 == 3)
        {
            chestGot[2].SetActive(true);
        }
        else
        {
            chestGot[2].SetActive(false);
        }
    }
    private (int,int,int) GetChest()
    {
        chestOpen1 = PlayerPrefs.GetInt(chest1, chestOpen1);
        chestOpen2 = PlayerPrefs.GetInt(chest2, chestOpen2);
        chestOpen3 = PlayerPrefs.GetInt(chest3, chestOpen3);
        return (chestOpen1,chestOpen2,chestOpen3);
    }
    private void Start()
    {
        GetChest();
    }
    private void Update()
    {
        WhenGotChest();
    }
}
