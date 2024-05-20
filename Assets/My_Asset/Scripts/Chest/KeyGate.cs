using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
{
    [SerializeField] private GameObject keyGate;
    [SerializeField] private EnableChestOnHead enableKey;
    private bool getKey;

    public bool GetKey { get => getKey; set => getKey = value; }

    private void OnTriggerEnter2D(Collider2D Key)
    {
        if(Key.CompareTag("Player"))
        {
            GetKey = true;
            gameObject.SetActive(false);
            enableKey?.EnableKey();
        }
    }
}
