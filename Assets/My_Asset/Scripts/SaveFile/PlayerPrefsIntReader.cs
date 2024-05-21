using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsIntReader : MonoBehaviour
{
    [SerializeField] private string keyName;
    [SerializeField] private int value;

    public int Value { get => value; set => this.value = value; }

    [ContextMenu("Get")]
    public int Get()
    {
        Value = PlayerPrefs.GetInt(keyName, Value);
        return Value;
    }
}
