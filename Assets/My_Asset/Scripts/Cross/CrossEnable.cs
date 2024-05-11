using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossEnable : MonoBehaviour
{
    [SerializeField] private GameObject crossObject;
    //[SerializeField] private int delay;
    //bool crossEnable;
    private void OnTriggerEnter2D(Collider2D cross)
    {
        if(cross.CompareTag("Player"))
        {
            crossObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D cross)
    {
        if(cross.CompareTag("Player"))
        {
            crossObject.SetActive(false);
        }
    }
}
