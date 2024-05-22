
using UnityEngine;

public class PlayerPrefsIntSaver : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private int value;

    public int Value { get => value; set => this.value = value; }

    [ContextMenu("Save")]
    public void Save()
    {
        PlayerPrefs.SetInt(keyName, Value);
    }
    
}
