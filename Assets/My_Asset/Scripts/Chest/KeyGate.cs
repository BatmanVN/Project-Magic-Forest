using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
{
    [SerializeField] private GameObject keyGate;
    [SerializeField] private EnableChestOnHead enableKey;
    public bool getKey;
    private void OnTriggerEnter2D(Collider2D Key)
    {
        if(Key.CompareTag("Player"))
        {
            getKey = true;
            gameObject.SetActive(false);
            enableKey?.EnableKey();
        }
    }
}
