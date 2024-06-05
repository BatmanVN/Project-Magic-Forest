
using UnityEngine;
using UnityEngine.UI;

public class CoinSave : MonoBehaviour
{
    [SerializeField] private string coinName;
    [SerializeField] private int saveCoin;
    [SerializeField] private GetCoin getcoin;
    [SerializeField] private Text coinText;
    [ContextMenu("SaveCoin")]
    private void SaveCoin()
    {
        PlayerPrefs.SetInt(coinName, getcoin.CointAmount);
    }
    private void TextCoin()
    {
        saveCoin = getcoin.CointAmount;
        coinText.text = getcoin.CointAmount.ToString();
    }
    private void Update()
    {
        TextCoin();
    }
    private void Start()
    {
        SaveCoin();
    }
}
