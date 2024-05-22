
using UnityEngine;
using UnityEngine.UI;

public class CoinSave : MonoBehaviour
{
    [SerializeField] private string coinName;
    [SerializeField] private int coinAmount;


    public int CoinAmount { get => coinAmount; set => coinAmount = value; }

    [ContextMenu("SaveCoin")]
    private void SaveCoin()
    {
         PlayerPrefs.SetInt(coinName, CoinAmount);
    }

}
