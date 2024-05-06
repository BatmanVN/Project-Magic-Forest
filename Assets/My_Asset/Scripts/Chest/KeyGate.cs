using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGate : MonoBehaviour
{
    [SerializeField] private GameObject keyGate;
    public bool getKey;
    private void OnTriggerEnter2D(Collider2D Key)
    {
        if(Key.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            getKey = true;
        }
    }
}
